# More Money start

Can be found [here](https://thunderstore.io/c/lethal-company/p/299792458/MoreMoneyStart/)

- Adds 1000 credits as the base amount when starting a new game or fail to meet the quota and start the game again.
- Now you can go to titan as you start a new game without grinding :))

## Change Log

## V2.1.0

- Mod now works with version 45
- Simplified the code a lot (basically one line now)

### V2.0.0

- The starting amount is now configurable
  - To configure the starting amount do as follows:
    - Find lethal company in your steam library and browse local files (under properties -> Installed Files -> Browse)
    - Go to this folder BepInEx -> config and open the file 299792458.MoreMoneyStart in notepad or a text editor
      - If this file is not there please run your game once, start a new world and then close the game. this should generate the file
    - Now the file contents should look like below

```    
## Settings file was created by plugin MoreMoneyStart v1.2.0
## Plugin GUID: 299792458.MoreMoneyStart

[Starting Amount]

## The starting amount can be configured here
# Setting type: Int32
# Default value: 1000
Starting Amount = 1000
```

You can the `Starting Amount = 1000` to whatever you like. Then save the file and run the game!

### V1.2.0

- Added Money reset on failed runs
