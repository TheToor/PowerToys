#include "pch.h"
#include "enterprise_settings.h"

#include <common/SettingsAPI/settings_helpers.h>

json::JsonObject load_enterprise_settings()
{
    auto loaded = PTSettingsHelper::load_enterprise_settings();
    return loaded;
}
