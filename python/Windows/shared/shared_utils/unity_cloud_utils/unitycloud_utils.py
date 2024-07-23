import os

import unity_cloud
from unity_cloud import AssetCreation, FileUploadInformation, AssetType, CollectionCreation, AssetUpdate


def AssetExists(asset_name, org_id, project_id):
    asset_list = unity_cloud.assets.get_asset_list(org_id, project_id)
    for asset in asset_list:
        if asset.name == asset_name:
            print("Asset Exists")
            return asset
        else:
            print("Asset Doesnt Exist")
            return None


def CreateAndPublishFilesToAsset(asset_name, model_files, org_id, project_id, collection_path, tags):
    try:
        asset = AssetExists(asset_name, org_id, project_id)
        if asset is None:
            asset = CreateAsset(asset_name, org_id, project_id, tags)

        source_dataset_id = GetSourceDataSet(asset.id, asset.version, org_id, project_id)
        for modelFile in model_files:
            UploadAsset(asset.id, asset.version, modelFile, org_id, project_id, source_dataset_id)
        if(collection_path!=""):
            if CheckCollectionExists(org_id, project_id, collection_path):
                LinkAssetToCollection(org_id, project_id, collection_path, asset.id)
            else:
                CreateCollection(collection_path, org_id, project_id)
                LinkAssetToCollection(org_id, project_id, collection_path, asset.id)
        PublishAsset(asset.id, asset.version, org_id, project_id)

    except Exception as e:
        print(f'Failed to create asset: {asset_name}')
        print(e)


def PublishAsset(asset_id, asset_version, org_id, project_id):
    print("Publish the asset")
    unity_cloud.assets.publish_asset(
        org_id=org_id,
        project_id=project_id,
        asset_id=asset_id,
        asset_version=asset_version)


def CheckCollectionExists(collection_name, org_id, project_id):
    collections = unity_cloud.assets.list_collections(org_id, project_id)
    for collection in collections:
        if collection.name == collection_name:
            return True
        else:
            return False


def CreateCollection(collection_name, org_id, project_id):
    collection_creation = CollectionCreation(
        name=collection_name,
        parent_path="",
        description="This collection was created by a pixyzSDK process"
    )
    unity_cloud.assets.create_collection(collection_creation, org_id, project_id)
def UploadAsset(asset_id, asset_version, modelFile, org_id, project_id, dataset_id):
    print(f"Uploading {os.path.basename(modelFile)} to the asset")
    upload = FileUploadInformation(
        organization_id=org_id,
        project_id=project_id,
        asset_id=asset_id,
        asset_version=asset_version,
        dataset_id=dataset_id,
        upload_file_path=modelFile,
        cloud_file_path=os.path.basename(modelFile)
    )
    unity_cloud.assets.upload_file(upload)


def GetSourceDataSet(asset_id, asset_version, org_id, project_id):
    print("Get the source dataset id")
    datasets = unity_cloud.assets.get_dataset_list(
        org_id=org_id,
        project_id=project_id,
        asset_id=asset_id,
        asset_version=asset_version)
    source_dataset_id = datasets[0].id
    return source_dataset_id


def LinkAssetToCollection(org_id, project_id, collection_path, asset_id):
    print("Adding asset to collection " + collection_path)
    unity_cloud.assets.link_assets_to_collection(org_id, project_id, collection_path, [asset_id])


def CreateAsset(asset_name, org_id, project_id, tags):
    print("Creating the asset")
    asset_creation = AssetCreation(
        name=asset_name,
        type=AssetType.MODEL_3D,  # Change this to the asset type you want to create
        description=f'{asset_name} from Unity Cloud',
        tags=tags)  # Add tags as string values
    asset = unity_cloud.assets.create_asset(
        asset_creation=asset_creation,
        org_id=org_id,
        project_id=project_id)
    return asset
