# Importing the package

Add this scoped registry.

```json
"scopedRegistries": [
    {
      "name": "Mr. Watts UPM Registry",
      "url": "https://gitlab.com/api/v4/projects/27157125/packages/npm/",
      "scopes": [
        "io.mrwatts"
      ]
    }
  ]
```

Add the following dependency in the **manifest.json** file in the "Packages" folder.

```json
"io.mrwatts.statekeepers": "1.0.0"
```

The version number should be the latest version of the package (unless you want to target an older version on purpose).

# Package Usage

This package depends on `io.mrwatts.fuelinject`.

To track the state of any object with type `Type`, add the following in any ContainerModule, where `builder` is of type `ContainerBuilder`:

```csharp
builder.RegisterTypedStateKeeper<Type>();
```

If you want to set the initial state of the object, you can set the value to `initialValue` as follows:

```csharp
builder.RegisterTypedStateKeeper<Type>(initialValue);
```