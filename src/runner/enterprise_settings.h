#pragma once

#include <common/utils/json.h>

struct EnterpriseSettings
{
    bool isAutoUpdateEnabled;

    std::map<std::wstring, bool> isModulesEnabledMap;
};

json::JsonObject load_enterprise_settings();