NebulaForge Interactive – Internal Development Logbook
This logbook contains entries related to the development of the game 'Shadow Protocol'. Each entry documents a specific issue encountered during development, its cause, the fix (if applied), and the current status. Entries marked as 'Not yet fixed' are tasks for students to complete as part of their assessment.

Entry 001 – Player Movement Bug
Issue: Player was unable to move backward using the 'S' key.
Cause: The input axis for 'Vertical' was not correctly mapped in the Input Manager.
Fix: Updated Input Manager settings to include 'S' as a negative axis for 'Vertical'.
Status: Fixed and tested

Entry 002 – Enemy AI Not Chasing Player
Issue: Enemies were not moving toward the player when spotted.
Cause: The NavMeshAgent component was missing from the enemy prefab.
Fix: Added NavMeshAgent and set destination to player position when in range.
Status: Fixed and tested

Entry 003 – Gun Not Firing
Issue: Clicking the mouse did not fire the weapon.
Cause: The firing script was missing a reference to the camera for raycasting.
Fix: Added a reference to the main camera and updated the raycast logic.
Status: Fixed and tested

Entry 004 – Health UI Not Updating
Issue: Player health bar stayed full even after taking damage.

Cause: The health script was not updating the UI slider.
Fix: Connected the health script to the UI slider and updated it in TakeDamage().
Status: Fixed and tested

Entry 005 – Enemy Respawn System
Issue: Enemies do not respawn after being defeated.

Cause:
Fix:
Status: Not yet fixed

Entry 006 – Ammo Pickup Feature
Issue: Player runs out of ammo.

Cause: N/A
Fix:
Status: Not yet fixed
