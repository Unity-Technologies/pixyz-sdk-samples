import unity_cloud

key_id = "KEYID"
secret_key = "SECRETKEY"


def unitycloud_init():
    print("Initializing Unity cloud service account")
    try:
        unity_cloud.initialize()
        unity_cloud.identity.service_account.use(key_id, secret_key)
    except Exception as e:
        print(e)