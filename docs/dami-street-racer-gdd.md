# Dami Street Racer - Game Design Document (GDD)

## 1. Game Overview

### 1.1 Game Title
Dami Street Racer

### 1.2 Genre
3D arcade racing game with realistic driving feel, mobile-first play, and competitive multiplayer.

### 1.3 Platform
- Android mobile
- Google Play Store release
- Possible future expansion: iOS, PC, web

### 1.4 Target Audience
- Ages 16+
- Players who enjoy street racing, quick competitive gameplay, progression loops, and custom cars
- Casual to mid-core mobile racing fans

### 1.5 Core Vision
Dami Street Racer is a mobile-first street racing game where players build a garage, upgrade vehicles, race through city streets, compete in online multiplayer events, and climb the ranks through a rewarding progression system. The game balances realistic driving feel with accessible mobile controls to appeal to both casual and competitive drivers.

### 1.6 Unique Selling Points
- Realistic but mobile-friendly driving physics
- Offline racing for no-internet play
- Local split-screen multiplayer support
- Online multiplayer race events
- Garage progression and customization
- Daily, weekly, and seasonal events
- Cosmetic-first monetization to avoid pay-to-win design

---

## 2. Game Objective

The player’s goal is to evolve from a newcomer street racer to a respected city champion by:
- winning races
- earning coins and XP
- upgrading and customizing cars
- unlocking new cars and tracks
- competing in multiplayer and progression-based events

---

## 3. Core Gameplay Loop

The main loop is:
1. Select a car and track
2. Enter a race or event
3. Drive to win and beat rivals or AI opponents
4. Earn coins, XP, and rewards
5. Upgrade and customize the garage
6. Unlock more cars, tracks, and challenges
7. Repeat in daily and weekly competitive events

This loop must be fast, rewarding, and repeatable in short sessions.

---

## 4. Game Modes

### 4.1 Offline Single Player
- Quick race
- Career mode
- Time trial
- Challenge missions

### 4.2 Local Multiplayer
- 2-player split-screen racing
- Same-device local competition

### 4.3 Online Multiplayer
- Quick match lobby
- Real-time races
- Leaderboards
- Ranked and casual modes

### 4.4 Career Mode
- Progression through tiers and reputation
- Unlock new tracks and cars
- Compete in increasingly difficult races

### 4.5 Daily Challenges
- Win races
- Drift for a target score
- Use nitro a certain number of times
- Finish within a time target

### 4.6 Weekly Events
- Featured tournaments
- Limited-time rewards
- Rare cars or exclusive skins

---

## 5. Player Experience

### 5.1 Player Fantasy
The player feels like a rising street racer in a competitive urban scene, building a reputation, customizing their car, and winning races across the city.

### 5.2 Emotional Goals
- Speed
- Competition
- Progression
- Achievement
- Customization
- Social recognition

---

## 6. Game Features

### 6.1 Core Racing Features
- 3D street racing gameplay
- Realistic steering and acceleration feel
- Drift scoring and handling response
- Nitro boost system
- Braking and cornering control
- Track checkpoints and lap counting
- Collision and damage effects

### 6.2 Car Systems
- Multiple car classes
- Garage management
- Purchase and unlock system
- Performance upgrades
- Cosmetic upgrades
- Car-specific stats and handling styles

### 6.3 Progression Systems
- Experience and leveling
- Coin rewards and progression economy
- Unlockable content
- Seasonal progression and rank ladder

### 6.4 Social and Retention Systems
- Leaderboards
- Daily rewards
- Friend invites
- Event pass or seasonal content
- Replay and stats sharing

### 6.5 Monetization Systems
- Free-to-play model
- Rewarded ads
- Cosmetic-only purchases
- Seasonal bundles
- Premium currency for event rewards and limited-time items

---

## 7. Gameplay Mechanics

### 7.1 Controls
Controls should be responsive and optimized for mobile play.

Recommended layout:
- Steering on the left side
- Throttle/brake controls on the right side
- Nitro button
- Pause control
- Drift assist button or tap-based drift mechanic

Optional support:
- Bluetooth controller support
- Touch sensitivity adjustments

### 7.2 Driving Feel
- Cars should feel distinct by class and upgrade level
- Cornering should include manageable drift behavior
- Nitro gives short bursts of speed and tactical advantage
- Acceleration and braking should feel satisfying and readable

### 7.3 Crash and Damage
- Collisions reduce speed and can affect handling temporarily
- Heavy impacts may spin or destabilize the car
- Cosmetic damage can be repaired with in-game currency

### 7.4 Race Flow
- Start countdown
- Race begins once the countdown completes
- Players finish based on placement or lap time
- Rewards are awarded on race end

---

## 8. Car System

### 8.1 Car Classes
- Street
- Sport
- Tuned
- Hyper
- Elite

### 8.2 Core Car Stats
- Top speed
- Acceleration
- Handling
- Nitro efficiency
- Durability

### 8.3 Upgrade Types
- Engine
- Suspension
- Tires
- Brakes
- Nitro system
- Handling tuning

### 8.4 Unlock System
- Starter car given to new players
- Additional cars unlocked via progression and currency
- Vehicle rarity tiers: Common, Rare, Epic, Legendary

### 8.5 Customization
- Paint color
- Wheel design
- Decals
- Neon accents
- Body kits
- Livery and cosmetic finish

---

## 9. Progression System

### 9.1 Player Leveling
Players earn XP from races, events, and daily activities. Levels unlock:
- new cars
- event access
- rare cosmetics
- rank progression milestones

### 9.2 Currency System
- Coins: standard race currency used for upgrades and repairs
- Gems: premium currency used for cosmetics and special bundles

### 9.3 Reward Structure
- Race wins grant coins and XP
- Daily challenges reward starter bonuses
- Weekly events grant high-tier rewards
- Seasonal leaderboard rewards unlock prestige items

### 9.4 Rank Ladder
- Rookie
- Street Rider
- City Competitor
- Elite Driver
- Champion
- Legend

---

## 10. Tracks and Environments

### 10.1 Track Types
- Downtown circuit
- Highway sprint
- Neon night route
- Wet city section
- Tunnel race
- Industrial zone

### 10.2 Visual Themes
- Urban city roads
- Modern districts
- Expressways with traffic
- Neon-lit nighttime racing
- Coastal or desert-inspired racing zones

### 10.3 Environmental Feature Set
- Traffic vehicles
- Buildings and billboards
- Day/night cycle
- Weather variations
- Dynamic lighting and reflections
- Sound-rich urban ambiance

---

## 11. Multiplayer Design

### 11.1 Online Multiplayer Features
- Quick match
- Real-time races
- Ranked and casual modes
- Friend invites
- Leaderboard updates

### 11.2 Lobby System
- Player joins room
- Selects car and track
- Waits for opponents
- Race starts when lobby is full or timer expires

### 11.3 Race Synchronization
- Race data should be synchronized with minimal delay
- Server-authoritative handling is recommended for fairness
- Matchmaking should account for player level and car class where possible

### 11.4 Anti-Cheat and Fairness
- Input validation
- Anti-exploit detection
- Player reporting tools
- Matchmaking fairness controls

---

## 12. UI / UX Design

### 12.1 Main Menu
- Play
- Garage
- Events
- Leaderboards
- Store
- Settings
- Profile

### 12.2 Garage Screen
- Owned cars
- Performance overview
- Upgrade buttons
- Selected car information
- Cosmetic options

### 12.3 Race HUD
- Speedometer
- Lap indicator
- Position ranking
- Nitro meter
- Timer
- Minimap

### 12.4 Store UI
- Car bundles
- Cosmetic panel
- Premium currency options
- Event-only offers

### 12.5 UX Goals
- Clear visual hierarchy
- Fast menu navigation
- Clean, readable text
- Minimal friction before racing

---

## 13. Audio and Visual Style

### 13.1 Visual Style
- Clean 3D city racing aesthetic
- Strong urban lighting and reflections
- Distinct car classes and silhouettes
- Polished but achievable mobile visuals

### 13.2 Audio
- Engine sound by vehicle class
- Nitro effect
- Collision impact sounds
- UI confirmation sounds
- Race ambience

### 13.3 Effects
- Tire smoke
- Dust trails
- Nitro trails
- Motion blur on high speed
- Weather particles

---

## 14. Content Plan

### 14.1 Initial Car Roster
- Dami X1
- Velocity GT
- Turbo Velo
- Street Rider S
- Apex RS

### 14.2 Initial Tracks
- Downtown Sprint
- Sunset Bridge
- Neon Rush
- Highway Drift
- Rust City Circuit

### 14.3 Event Types
- Daily challenge race
- Weekend sprint
- Drift challenge
- Nitro challenge
- Sprint tournament

---

## 15. Monetization Strategy

### 15.1 Business Model
- Free-to-play
- Cosmetic-first premium offers
- Rewarded ads for currency and boosters

### 15.2 Monetization Methods
- Premium currency packs
- Seasonal bundles
- Cosmetic skins
- Limited-time car packs
- Battle pass or event pass

### 15.3 Anti-Pay-to-Win Policy
- No direct pay-to-win upgrades
- Purchased content should be cosmetic or convenience oriented
- Keep balance fair for all players

---

## 16. Retention Plan

### 16.1 Daily Rewards
- Login streak rewards
- Daily objective completion bonus

### 16.2 Weekly Events
- Bonus payouts
- Featured track schedules
- Tournament rewards

### 16.3 Seasonal Drops
- Limited-time skins
- Rare vehicle bundles
- Leaderboard event rewards

### 16.4 Retention Goals
- Encourage repeated daily sessions
- Maintain visible progression
- Use events to create regular player habits

---

## 17. Technical Requirements

### 17.1 Platform Requirements
- Android 8.0+
- Recommended 3GB+ RAM for smooth play
- Device scaling for lower-end hardware

### 17.2 Engine
- Unity 3D preferred
- C# scripting
- Mobile optimization and quality settings

### 17.3 Backend Tools
- Firebase or custom backend for profile data
- Photon or synchronous custom networking for live races
- Google Play Billing for in-app purchases
- AdMob for rewarded ads
- Firebase Analytics for metrics

---

## 18. Production Roadmap

### Phase 1: MVP (Weeks 1–6)
- Single-player race prototype
- Garage system
- Upgrade logic
- Save system
- One city and two tracks
- Main menu and basic UI

### Phase 2: Content Expansion (Weeks 7–12)
- Additional tracks and cars
- Local multiplayer support
- Daily challenge system
- Race rewards and leaderboard data

### Phase 3: Online Multiplayer (Weeks 13–18)
- Lobby system
- Matchmaking
- Real-time race synchronization
- Leaderboard integration

### Phase 4: Polish and Store Preparation (Weeks 19–24)
- Audio and FX work
- UI polishing
- Store asset creation
- Beta testing
- App submission prep

---

## 19. Risks and Challenges

### 19.1 Technical Risks
- Performance issues on lower-end Android devices
- Multiplayer synchronization problems
- Save data integrity issues

### 19.2 Design Risks
- Driving controls may feel unresponsive
- Progression may feel too slow
- Monetization may weaken trust if poorly implemented

### 19.3 Mitigation
- Early mobile testing
- Prototype gameplay loops before full production
- Keep progression clear and fair
- Use cosmetic-focused monetization

---

## 20. Success Metrics

### 20.1 Core KPIs
- Daily active users
- Session length
- Race completion rate
- Daily challenge completion
- Multiplayer participation rate
- 1-day, 7-day, and 30-day retention

### 20.2 Content KPIs
- Most popular tracks
- Most used upgrades
- Favorite car classes
- Event engagement rate

---

## 21. Launch Requirements for Google Play

Before launch, the game must include:
- Google Play Billing integration
- Privacy policy
- Terms and conditions
- Age rating and content compliance
- App icon and screenshots
- Store description and promotional assets
- Android compatibility testing
- Crash reporting and analytics

---

## 22. Product Summary

Dami Street Racer is designed to be a competitive, mobile-first street racing game that blends realistic driving feel, quick progression, and exciting multiplayer competition. The game’s core appeal is built around short, satisfying racing sessions with visible progression, strong customization, and engaging event-based retention.

The long-term goal is to create a scalable racing title that can expand into more cities, cars, tracks, and online game modes while preserving strong performance and a fair, rewarding economy.

---

## 23. MVP Scope Summary

### Must-Have MVP Features
- 1 city
- 3–5 cars
- 2–3 tracks
- Offline race mode
- Garage and upgrade system
- Save system
- Daily reward flow
- Local multiplayer support
- Leaderboards

### Not Included in MVP
- Large open-world map
- Full-scale realistic simulation physics
- Advanced AI and complex weather system
- Large-scale multiplayer tournament system

---

## 24. Final Note

This GDD is a practical roadmap for building a mobile racing game with strong retention, easy progression, multiplayer hooks, and Play Store readiness. It can be expanded over time into a deeper production document as the game grows in size and complexity.

Next development steps should be:
1. Build the Unity project structure
2. Prototyping the first race scene
3. Implement basic garage and save systems
4. Add local multiplayer and improve car handling
5. Expand to online multiplayer and leaderboards
6. Prepare Android packaging and Play Store submission
