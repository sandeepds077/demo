import os

APP_NAME = os.getenv("APP_NAME", "demo-python-app")
ENVIRONMENT = os.getenv("ENVIRONMENT", "development")
FEATURE_FLAG = os.getenv("FEATURE_FLAG", "false")
LOG_LEVEL = os.getenv("LOG_LEVEL", "info")
API_TOKEN = os.getenv("API_TOKEN", "")
DB_PASSWORD = os.getenv("DB_PASSWORD", "")


def build_message() -> str:
    return f"{APP_NAME} is running in {ENVIRONMENT} with feature flag {FEATURE_FLAG} and log level {LOG_LEVEL}"


if __name__ == "__main__":
    print(build_message())
    if API_TOKEN and DB_PASSWORD:
        print("Secrets are available to the app.")
    else:
        print("Secrets are not configured yet.")
