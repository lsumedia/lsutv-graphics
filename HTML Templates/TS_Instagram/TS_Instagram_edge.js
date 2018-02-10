/*jslint */
/*global AdobeEdge: false, window: false, document: false, console:false, alert: false */
(function (compId) {

    "use strict";
    var im='images/',
        aud='media/',
        vid='media/',
        js='js/',
        fonts = {
        },
        opts = {
            'gAudioPreloadPreference': 'auto',
            'gVideoPreloadPreference': 'auto'
        },
        resources = [
        ],
        scripts = [
        ],
        symbols = {
            "stage": {
                version: "6.0.0",
                minimumCompatibleVersion: "5.0.0",
                build: "6.0.0.400",
                scaleToFit: "none",
                centerStage: "none",
                resizeInstances: false,
                content: {
                    dom: [
                        {
                            id: 'InstaSquare',
                            type: 'image',
                            rect: ['342px', '853px', '120px', '120px', 'auto', 'auto'],
                            opacity: '0',
                            fill: ["rgba(0,0,0,0)",im+"InstaSquare.svg",'0px','0px']
                        }
                    ],
                    style: {
                        '${Stage}': {
                            isStage: true,
                            rect: ['null', 'null', '1920px', '1080px', 'auto', 'auto'],
                            overflow: 'hidden',
                            fill: ["rgba(255,255,255,1)"]
                        }
                    }
                },
                timeline: {
                    duration: 4000,
                    autoPlay: true,
                    data: [
                        [
                            "eid8",
                            "top",
                            0,
                            1445,
                            "linear",
                            "${InstaSquare}",
                            '853px',
                            '248px'
                        ],
                        [
                            "eid9",
                            "top",
                            2000,
                            0,
                            "easeInOutCubic",
                            "${InstaSquare}",
                            '248px',
                            '248px'
                        ],
                        [
                            "eid12",
                            "top",
                            2415,
                            1585,
                            "easeInQuart",
                            "${InstaSquare}",
                            '248px',
                            '853px'
                        ],
                        [
                            "eid6",
                            "opacity",
                            0,
                            430,
                            "linear",
                            "${InstaSquare}",
                            '0',
                            '1'
                        ],
                        [
                            "eid15",
                            "opacity",
                            3750,
                            250,
                            "easeInQuart",
                            "${InstaSquare}",
                            '1',
                            '0'
                        ]
                    ]
                }
            }
        };

    AdobeEdge.registerCompositionDefn(compId, symbols, fonts, scripts, resources, opts);

    if (!window.edge_authoring_mode) AdobeEdge.getComposition(compId).load("TS_Instagram_edgeActions.js");
})("EDGE-478761831");
