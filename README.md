# Void Fields Stage Increment

It appears that when Hopoo changed the SceneType of Void Fields to make the stopwatch continue to run they didn't consider that this would also allow the stage count to increment upon leaving the stage. From the looks of it they wrote a hotfix to prevent this, but likely didn't release it due to the tech that was discovered around this (getting things a stage early such as family events, legendary chests, scavengers, etc...).

The shadow patch from Gearbox that added the meteors to each stage was built using the dev version of the game that Hopoo passed over, not the release that we had been playing this whole time, and so this hotfix was bundled into the patch, removing the ability to increment the stage count with Void Fields and thereby removing a bunch of tech. This mod very simply allows the new SceneType to increment the stage and reintroduces this tech once again.

# Changelog

**1.0.0**

-   Define new TimedIntermission SceneType missing from the RoR2 nuget package.
-   Add check to AdvanceStage method and increment the stage count if it matches the new SceneType.