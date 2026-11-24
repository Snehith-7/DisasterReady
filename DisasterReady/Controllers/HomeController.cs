using DisasterReady.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DisasterReady.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Learn(string topic)
        {
            var lesson = topic?.Trim().ToLowerInvariant() switch
            {
                "earthquake" => new
                {
                    Title = "Earthquake Safety",
                    Description = "Comprehensive structural preparedness, immediate life-safety postures, and post-tremor recovery guidelines.",
                    Icon = "🌍",
                    Before = new[]
                    {
                        "Anchor heavy furniture, bookcases, mirrors, and water heaters securely to wall studs with brackets or straps.",
                        "Identify structural safe zones in every room: under sturdy wooden desks, heavy tables, or against interior load-bearing walls away from glass windows.",
                        "Assemble a 72-hour Go-Bag with non-perishable food, water (minimum 3 liters per person/day), flashlights, whistle, spare batteries, and first-aid supplies.",
                        "Locate and label main shutoff valves for gas, water, and electricity; keep designated tools readily accessible nearby.",
                        "Establish a family and campus emergency communication plan, designating an out-of-area contact person to check in with.",
                        "Conduct regular 'Drop, Cover, and Hold On' drills to build immediate muscle memory for sudden ground tremors."
                    },
                    During = new[]
                    {
                        "Drop to your hands and knees immediately to prevent falls; cover your head and neck under a sturdy table, and hold on until shaking stops.",
                        "If indoors, remain inside. Do not run outside during active shaking—falling roof tiles, glass, and facade masonry are the primary hazards.",
                        "Stay clear of exterior windows, tall bookcases, hanging lighting fixtures, and heavy suspended architectural elements.",
                        "If in bed, stay there, curl face-down, and protect your head and neck with a thick pillow.",
                        "If outdoors, move immediately to a clear open area away from power lines, tall buildings, bridges, and streetlights, then drop to the ground.",
                        "If in a moving vehicle, pull over safely away from overpasses, bridges, and power lines, keep your seatbelt fastened, and remain inside."
                    },
                    After = new[]
                    {
                        "Check yourself and nearby peers for injuries and apply emergency first-aid before moving across debris.",
                        "Sniff for gas leaks or listen for hissing sounds. If suspected, shut off the gas valve, open windows, and evacuate immediately without touching electrical switches.",
                        "Anticipate severe aftershocks—partially weakened structures can collapse during secondary tremors.",
                        "Use stairs exclusively; never operate elevators until certified safe by structural inspectors.",
                        "Tune into official NDMA/SDMA emergency radio broadcasts and public alerts for verified information and shelter locations.",
                        "Conserve cell phone battery and network bandwidth—use SMS or text messaging for non-urgent wellness check-ins."
                    }
                },

                "flood" => new
                {
                    Title = "Flood Safety",
                    Description = "Inundation monitoring, rapid evacuation procedures, and safe post-flood sanitation guidelines.",
                    Icon = "🌊",
                    Before = new[]
                    {
                        "Know the elevation of your property and identify verified elevated evacuation routes out of low-lying floodplains.",
                        "Elevate critical electrical panels, water heaters, major appliances, and valuable documents to upper floors or waterproof safes.",
                        "Install backwater check valves in plumbing lines to prevent sewer waters from backing up through floor drains.",
                        "Stock up on water purification tablets, sealed drinking water, non-perishable food, and waterproof flashlights.",
                        "Regularly inspect and clear localized storm drains, gutters, and downspouts to prevent immediate rainfall accumulation.",
                        "Monitor Central Water Commission (CWC) flood forecasts, IMD weather warnings, and local river stage alerts."
                    },
                    During = new[]
                    {
                        "Evacuate immediately if ordered by civil authorities or if water begins rising rapidly around your dwelling.",
                        "Follow the 'Turn Around, Don't Drown' rule: never attempt to walk, swim, or drive through standing or moving floodwater.",
                        "Remember that just 15 cm (6 inches) of moving water can knock an adult off their feet, and 30–60 cm can float and carry away vehicles.",
                        "Before evacuating, shut off main electrical breakers and gas supplies if you can safely reach them without standing in water.",
                        "If trapped inside a multi-story building, climb to the highest floor or accessible roof; avoid closed attics without roof egress.",
                        "Stay completely away from submerged power lines, fallen utility poles, and transformers to prevent fatal electrocution."
                    },
                    After = new[]
                    {
                        "Wait for official clearance from civil defense and disaster marshals before returning to flooded areas.",
                        "Inspect foundations, retaining walls, and floors for cracks, undermining, or structural instability before entering buildings.",
                        "Discard any food, bottled beverages, or medicines that came into contact with floodwater—floodwaters contain sewage, fuel, and toxins.",
                        "Vigorously boil all drinking and cooking water for at least 1 minute until municipal health authorities declare water supplies safe.",
                        "Wear heavy rubber boots, thick work gloves, and protective masks during mud and debris cleanup to prevent infections and mold exposure.",
                        "Document all property loss and structural damage with high-resolution photos and timestamps for relief and insurance claims."
                    }
                },

                "fire" => new
                {
                    Title = "Fire Safety",
                    Description = "Smoke alarm protocols, tactical evacuation maneuvers, and burn prevention procedures.",
                    Icon = "🔥",
                    Before = new[]
                    {
                        "Install smoke detectors on every floor, inside dormitories/bedrooms, and along hallways; test them monthly and replace batteries biannually.",
                        "Identify and memorize two clear escape exits from every room and keep emergency exit stairwells and corridors completely unobstructed.",
                        "Equip key areas with certified ABC dry chemical fire extinguishers and train occupants on the PASS method (Pull, Aim, Squeeze, Sweep).",
                        "Never overload electrical outlets, power strips, or daisy-chain extension cords; inspect wiring regularly for fraying or scorching.",
                        "Safely store flammable liquids, chemicals, and gas cylinders in ventilated, fire-resistant cabinets far from ignition sources.",
                        "Conduct unannounced fire evacuation drills every academic term and designate a clear outdoor assembly muster point."
                    },
                    During = new[]
                    {
                        "Activate the nearest manual fire alarm pull station and dial 101/112 immediately upon spotting smoke or flame.",
                        "Crawl low under smoke—superheated toxic gases and carbon monoxide accumulate near the ceiling; cleanest air is 30–60 cm above the floor.",
                        "Feel doors and metal handles with the back of your hand before opening. If hot or smoke is seeping through, keep it shut and use your alternate exit.",
                        "Never use elevators during a fire—shafts act as chimneys for toxic smoke, and power cuts can trap occupants. Always use emergency stairways.",
                        "If your clothing catches fire: Stop, Drop to the ground, Cover your face with your hands, and Roll until the flames are smothered.",
                        "If trapped in a room: close all doors, seal gaps with wet towels/cloth, call emergency services with your exact room number, and signal at a window."
                    },
                    After = new[]
                    {
                        "Proceed straight to the designated outdoor assembly point and report immediately to your floor warden or safety marshal for roll call.",
                        "Never re-enter a burning or extinguished building until the Fire Officer or civil defense authorities issue an official written all-clear.",
                        "Inform first responders immediately if anyone is missing, injured, or trapped, providing their last known room location.",
                        "Seek medical evaluation for burns and smoke inhalation—airway burns and carbon monoxide poisoning often present delayed symptoms.",
                        "Discard food, beverages, and pharmaceuticals exposed to heat, smoke, or fire-extinguishing chemical agents.",
                        "Cooperate with fire safety investigators by providing an accurate account of alarms, initial smoke sightings, and evacuation timelines."
                    }
                },

                "cyclone" => new
                {
                    Title = "Cyclone Safety",
                    Description = "IMD radar tracking, structural fortification against gale winds, and storm surge survival procedures.",
                    Icon = "🌀",
                    Before = new[]
                    {
                        "Monitor official India Meteorological Department (IMD) bulletins, radio warnings, and coastal storm surge predictions.",
                        "Fortify loose structural elements: secure roof sheets, board or tape glass windows, and trim overhanging tree branches near power lines.",
                        "Bring outdoor furniture, garbage bins, tools, and loose metal sheets indoors or anchor them securely to prevent them from becoming deadly projectiles.",
                        "Stock a 5-day supply of drinking water (4 liters per person/day), non-perishable foods, essential medications, and spare power banks.",
                        "Identify the nearest certified Pucca cyclone shelter or concrete community building and plan a safe walking route to it.",
                        "Refuel vehicles and fully charge all mobile devices, emergency lamps, and power storage units ahead of expected electrical grid shutoffs."
                    },
                    During = new[]
                    {
                        "Stay indoors in a reinforced central room, hallway, or bathroom on the lowest floor, well away from glass windows and doors.",
                        "Switch off main electrical breakers and disconnect LPG gas cylinder regulators to prevent power surges and fire outbreaks.",
                        "Beware the 'Eye of the Storm': if wind and rain abruptly halt, do NOT step outside—violent winds will soon resume from the opposite direction.",
                        "Never go outside to film, sightsee, or inspect damage during high winds; gale forces exceeding 100 km/h make flying debris lethal.",
                        "Stay clear of coastal beaches, river mouths, and low-lying canals—storm surges can inundate areas with sudden 3 to 6-meter walls of seawater.",
                        "Conserve cell phone battery by enabling power-saving mode, keeping calls strictly to life-threatening distress emergencies."
                    },
                    After = new[]
                    {
                        "Remain inside the shelter until district authorities, SDMA, and IMD officially declare that the cyclone has completely passed.",
                        "Steer clear of fallen electrical wires, sagging poles, and water puddles near power infrastructure—always treat downed lines as live and deadly.",
                        "Do not drive through debris-strewn or flooded roads; bridges, culverts, and trees may be structurally compromised or ready to fall.",
                        "Drain stagnant water from containers, roofs, and yards immediately to prevent post-cyclone mosquito breeding and waterborne disease outbreaks.",
                        "Boil or chlorinate all drinking water thoroughly before use; coastal flooding frequently infiltrates municipal drinking water networks.",
                        "Check on elderly neighbors, children, and persons with disabilities to provide assistance, rations, and reassurance."
                    }
                },

                _ => null
            };

            if (lesson == null)
            {
                return NotFound();
            }

            ViewBag.Title = lesson.Title;
            ViewBag.Description = lesson.Description;
            ViewBag.Icon = lesson.Icon;
            ViewBag.Before = lesson.Before;
            ViewBag.During = lesson.During;
            ViewBag.After = lesson.After;

            return View();
        }
        public IActionResult Quiz()
        {
            return View();
        }


        public IActionResult Emergency()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
