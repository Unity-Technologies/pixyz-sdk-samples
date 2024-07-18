import unity_cloud

keyID = "KEYID"
secretKey = "SECRETKEY"


def unitycloud_init():
    print("Initializing Unity cloud service account")
    try:
        unity_cloud.initialize()
        unity_cloud.identity.service_account.use(keyID, secretKey)
    except Exception as e:
        print(e)