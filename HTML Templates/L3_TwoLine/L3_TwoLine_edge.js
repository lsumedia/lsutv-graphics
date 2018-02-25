/*jslint */
/*global AdobeEdge: false, window: false, document: false, console:false, alert: false */
(function (compId) {

    "use strict";
    var im='images/',
        aud='media/',
        vid='media/',
        js='js/',
        fonts = {
            'lato, sans-serif': '<script src=\"http://use.edgefonts.net/lato:n9,i4,n1,i7,i9,n7,i1,i3,n4,n3:all.js\"></script>'        },
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
                            id: 'Group',
                            type: 'group',
                            rect: ['-539px', '872', '525', '100', 'auto', 'auto'],
                            c: [
                            {
                                id: 'Background',
                                type: 'rect',
                                rect: ['5px', '0px', '520px', '100px', 'auto', 'auto'],
                                fill: ["rgba(251,251,251,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"]
                            },
                            {
                                id: 'Border',
                                type: 'rect',
                                rect: ['0px', '0px', '10px', '100px', 'auto', 'auto'],
                                fill: ["rgba(236,34,40,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"]
                            },
                            {
                                id: 'f1',
                                type: 'text',
                                rect: ['27px', '54px', '477px', '34px', 'auto', 'auto'],
                                text: "<p style=\"margin: 0px;\">​f1</p>",
                                align: "left",
                                userClass: "autoscale",
                                font: ['lato, sans-serif', [24, "px"], "rgba(0,0,0,1)", "500", "none", "normal", "break-word", ""],
                                textStyle: ["", "", "", "", "none"]
                            },
                            {
                                id: 'f0',
                                type: 'text',
                                rect: ['27px', '5px', '477px', '51px', 'auto', 'auto'],
                                text: "<p style=\"margin: 0px;\">​f0</p>",
                                align: "left",
                                userClass: "autoscale",
                                font: ['lato, sans-serif', [36, "px"], "rgba(0,0,0,1)", "500", "none", "normal", "break-word", ""],
                                textStyle: ["", "", "", "", "none"]
                            }]
                        }
                    ],
                    style: {
                        '${Stage}': {
                            isStage: true,
                            rect: ['null', 'null', '1920px', '1080px', 'auto', 'auto'],
                            overflow: 'hidden',
                            fill: ["rgba(171,171,171,0.00)"]
                        }
                    }
                },
                timeline: {
                    duration: 3000,
                    autoPlay: true,
                    labels: {
                        "outro": 1750
                    },
                    data: [
                        [
                            "eid52",
                            "left",
                            630,
                            1000,
                            "easeOutCirc",
                            "${Group}",
                            '-539px',
                            '192px'
                        ],
                        [
                            "eid55",
                            "left",
                            2000,
                            1000,
                            "easeInCirc",
                            "${Group}",
                            '192px',
                            '-539px'
                        ]
                    ]
                }
            }
        };

    AdobeEdge.registerCompositionDefn(compId, symbols, fonts, scripts, resources, opts);

    if (!window.edge_authoring_mode) AdobeEdge.getComposition(compId).load("L3_TwoLine_edgeActions.js");
})("EDGE-478761831");
