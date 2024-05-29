import unity_cloud

keyID = "9e4e2cd8-d1b1-4443-b283-7cef3050f96c"
secretKey = "pVfwUHHqk4sX8e1y3-98u0oi_sH_KS7W"


def unitycloud_init():
    print("Initializing Unity cloud service account")
    try:
        unity_cloud.initialize()
        unity_cloud.identity.service_account.use(keyID, secretKey)
    except Exception as e:
        print(e)