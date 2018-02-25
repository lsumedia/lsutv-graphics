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
                            rect: ['192', '872px', '1536', '66', 'auto', 'auto'],
                            c: [
                            {
                                id: 'Rectangle',
                                type: 'rect',
                                rect: ['0px', '0px', '420px', '60px', 'auto', 'auto'],
                                fill: ["rgba(255,255,255,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"]
                            },
                            {
                                id: 'RectangleCopy',
                                type: 'rect',
                                rect: ['auto', '0px', '420px', '60px', '0px', 'auto'],
                                fill: ["rgba(255,255,255,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"]
                            },
                            {
                                id: 'Rectangle2Copy',
                                type: 'rect',
                                rect: ['1526px', '0px', '10px', '60px', 'auto', 'auto'],
                                fill: ["rgba(236,34,40,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"]
                            },
                            {
                                id: 'Rectangle2',
                                type: 'rect',
                                rect: ['0px', '0px', '10px', '60px', 'auto', 'auto'],
                                fill: ["rgba(236,34,40,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"]
                            },
                            {
                                id: 'f0',
                                type: 'text',
                                rect: ['26px', '4px', '392px', '57px', 'auto', 'auto'],
                                text: "<p style=\"margin: 0px;\">​f0</p>",
                                align: "left",
                                font: ['lato, sans-serif', [36, "px"], "rgba(0,0,0,1)", "500", "none", "normal", "break-word", ""],
                                textStyle: ["", "", "", "", "none"]
                            },
                            {
                                id: 'f1',
                                type: 'text',
                                rect: ['1142px', '4px', '368px', '57px', 'auto', 'auto'],
                                text: "<p style=\"margin: 0px; text-align: right;\">f1​</p>",
                                align: "right",
                                userClass: "autoscale",
                                font: ['lato, sans-serif', [36, "px"], "rgba(0,0,0,1)", "500", "none", "normal", "break-word", "normal"],
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
                            "eid100",
                            "top",
                            500,
                            1000,
                            "easeOutCirc",
                            "${Group}",
                            '1095px',
                            '872px'
                        ],
                        [
                            "eid103",
                            "top",
                            2000,
                            1000,
                            "easeInCirc",
                            "${Group}",
                            '872px',
                            '1095px'
                        ]
                    ]
                }
            }
        };

    AdobeEdge.registerCompositionDefn(compId, symbols, fonts, scripts, resources, opts);

    if (!window.edge_authoring_mode) AdobeEdge.getComposition(compId).load("L3_DoubleStrap_edgeActions.js");
})("EDGE-478761831");
