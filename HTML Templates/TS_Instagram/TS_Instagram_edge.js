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
                            id: 'TombstoneMain',
                            type: 'group',
                            rect: ['192', '1081px', '420', '640', 'auto', 'auto'],
                            c: [
                            {
                                id: 'Background',
                                type: 'rect',
                                rect: ['1px', '0px', '420px', '640px', 'auto', 'auto'],
                                fill: ["rgba(255,255,255,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"],
                                boxShadow: ["", 0, 7, 5, 0, "rgba(0,0,0,0.20)"]
                            },
                            {
                                id: '_image',
                                type: 'rect',
                                rect: ['0px', '10px', '420px', '420px', 'auto', 'auto'],
                                fill: ["rgba(185,43,43,1.00)"],
                                stroke: [1,"rgb(0, 0, 0)","none"]
                            },
                            {
                                id: 'Profile',
                                type: 'group',
                                rect: ['124px', '449px', '171', '60', 'auto', 'auto'],
                                c: [
                                {
                                    id: '_description',
                                    type: 'text',
                                    rect: ['-95px', '86px', '364px', '94px', 'auto', 'auto'],
                                    overflow: 'hidden',
                                    text: "<p style=\"margin: 0px;\">​Shorter text description about the image, font should be constant but we don't need to have the full text displa..<span style=\"color: rgba(0, 0, 0, 0.137255);\">​</span></p>",
                                    align: "left",
                                    font: ['lato, sans-serif', [21, "px"], "rgba(0,0,0,1.00)", "500", "none", "normal", "break-word", "normal"],
                                    textStyle: ["", "", "", "", "none"]
                                },
                                {
                                    id: '_fullname',
                                    type: 'text',
                                    rect: ['0px', '0px', 'auto', 'auto', 'auto', 'auto'],
                                    text: "<p style=\"margin: 0px;\">​Tyrion Lannister</p>",
                                    align: "left",
                                    font: ['lato, sans-serif', [24, "px"], "rgba(0,0,0,1)", "400", "none", "normal", "break-word", "nowrap"],
                                    textStyle: ["", "", "", "", "none"]
                                },
                                {
                                    id: '_handle',
                                    type: 'text',
                                    rect: ['2px', '31px', 'auto', 'auto', 'auto', 'auto'],
                                    text: "<p style=\"margin: 0px;\">​@therealhalfman<span style=\"font-size: 18px;\">​</span></p>",
                                    align: "left",
                                    font: ['lato, sans-serif', [21, "px"], "rgba(68,68,68,1.00)", "500", "none", "normal", "break-word", "nowrap"],
                                    textStyle: ["", "", "", "", "none"]
                                },
                                {
                                    id: '_displaypic',
                                    type: 'rect',
                                    rect: ['-95px', '-3px', '75px', '75px', 'auto', 'auto'],
                                    fill: ["rgba(185,43,43,1)"],
                                    stroke: [1,"rgb(0, 0, 0)","none"]
                                }]
                            },
                            {
                                id: 'Topbar',
                                type: 'rect',
                                rect: ['0px', '0px', '420px', '10px', 'auto', 'auto'],
                                fill: ["rgba(138,58,185,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"]
                            }]
                        },
                        {
                            id: 'InstaSquare',
                            type: 'image',
                            rect: ['342px', '1150px', '120px', '120px', 'auto', 'auto'],
                            opacity: '1',
                            fill: ["rgba(0,0,0,0)",im+"InstaSquare.svg",'0px','0px']
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
                        "outro": 1500
                    },
                    data: [
                        [
                            "eid8",
                            "top",
                            0,
                            1000,
                            "easeOutExpo",
                            "${InstaSquare}",
                            '1150px',
                            '248px'
                        ],
                        [
                            "eid9",
                            "top",
                            1500,
                            0,
                            "easeInOutCubic",
                            "${InstaSquare}",
                            '248px',
                            '248px'
                        ],
                        [
                            "eid12",
                            "top",
                            2000,
                            1000,
                            "easeInExpo",
                            "${InstaSquare}",
                            '248px',
                            '1150px'
                        ],
                        [
                            "eid41",
                            "top",
                            0,
                            1000,
                            "easeOutExpo",
                            "${TombstoneMain}",
                            '1081px',
                            '332px'
                        ],
                        [
                            "eid44",
                            "top",
                            2000,
                            1000,
                            "easeInExpo",
                            "${TombstoneMain}",
                            '332px',
                            '1081px'
                        ]
                    ]
                }
            }
        };

    AdobeEdge.registerCompositionDefn(compId, symbols, fonts, scripts, resources, opts);

    if (!window.edge_authoring_mode) AdobeEdge.getComposition(compId).load("TS_Instagram_edgeActions.js");
})("EDGE-478761831");
