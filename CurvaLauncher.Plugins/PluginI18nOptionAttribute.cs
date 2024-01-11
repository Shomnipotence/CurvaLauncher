﻿namespace CurvaLauncher.Plugin;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class PluginI18nOptionAttribute : Attribute
{
    public object? NameKey { get; set; }
    public object? DescriptionKey { get; set; }

    public bool AllowTextMultiline { get; set; } = false;

    public PluginI18nOptionAttribute()
    {
    }

    public PluginI18nOptionAttribute(object? nameKey)
    {
        NameKey = nameKey;
    }

    public PluginI18nOptionAttribute(object? nameKey, object? descriptionKey)
    {
        NameKey = nameKey;
        DescriptionKey = descriptionKey;
    }
}