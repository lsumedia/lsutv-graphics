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
                            rect: ['192', '1081px', '420', '432px', 'auto', 'auto'],
                            overflow: 'visible',
                            c: [
                            {
                                id: 'Background',
                                type: 'rect',
                                rect: ['1px', '0px', '420px', '432px', 'auto', 'auto'],
                                fill: ["rgba(255,255,255,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"],
                                boxShadow: ["", 2, 5, 8, 0, "rgba(0,0,0,0.20)"]
                            },
                            {
                                id: 'Profile',
                                type: 'group',
                                rect: ['124px', '77px', '171', '60', 'auto', 'auto'],
                                c: [
                                {
                                    id: '_content',
                                    type: 'text',
                                    rect: ['-95px', '86px', '364px', '220px', 'auto', 'auto'],
                                    overflow: 'hidden',
                                    text: "<p style=\"margin: 0px;\">​_content<span style=\"color: rgba(0, 0, 0, 0.137255);\"></span></p>",
                                    align: "left",
                                    font: ['lato, sans-serif', [32, "px"], "rgba(0,0,0,1.00)", "500", "none", "normal", "break-word", "normal"],
                                    textStyle: ["", "", "", "", "none"]
                                },
                                {
                                    id: '_fullname',
                                    type: 'text',
                                    rect: ['0px', '0px', 'auto', 'auto', 'auto', 'auto'],
                                    text: "<p style=\"margin: 0px;\">​_fullname</p>",
                                    align: "left",
                                    font: ['lato, sans-serif', [24, "px"], "rgba(0,0,0,1)", "400", "none", "normal", "break-word", "nowrap"],
                                    textStyle: ["", "", "", "", "none"]
                                },
                                {
                                    id: '_handle',
                                    type: 'text',
                                    rect: ['2px', '31px', 'auto', 'auto', 'auto', 'auto'],
                                    text: "<p style=\"margin: 0px;\">​_handle</p>",
                                    align: "left",
                                    font: ['lato, sans-serif', [21, "px"], "rgba(68,68,68,1.00)", "500", "none", "normal", "break-word", "nowrap"],
                                    textStyle: ["", "", "", "", "none"]
                                },
                                {
                                    id: 'displaypic',
                                    type: 'rect',
                                    rect: ['-95px', '-3px', '75px', '75px', 'auto', 'auto'],
                                    fill: ["rgba(0,0,0,1.00)"],
                                    stroke: [1,"rgb(0, 0, 0)","none"]
                                }]
                            },
                            {
                                id: 'Topbar',
                                type: 'rect',
                                rect: ['0px', '0px', '420px', '10px', 'auto', 'auto'],
                                fill: ["rgba(0,172,237,1.00)"],
                                stroke: [0,"rgb(0, 0, 0)","none"]
                            }]
                        },
                        {
                            id: 'InstaSquare',
                            type: 'image',
                            rect: ['342px', '1150px', '120px', '120px', 'auto', 'auto'],
                            opacity: '1',
                            fill: ["rgba(0,0,0,0)",im+"TwitterSquare.svg",'0px','0px'],
                            boxShadow: ["", 0, 7, 5, 0, "rgba(0,0,0,0.12)"]
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
                    duration: 3250,
                    autoPlay: true,
                    labels: {
                        "outro": 1750
                    },
                    data: [
                        [
                            "eid48",
                            "boxShadow.offsetV",
                            1130,
                            0,
                            "linear",
                            "${InstaSquare}",
                            '7px',
                            '7px'
                        ],
                        [
                            "eid41",
                            "top",
                            250,
                            1000,
                            "easeOutExpo",
                            "${TombstoneMain}",
                            '1081px',
                            '540px'
                        ],
                        [
                            "eid44",
                            "top",
                            2250,
                            1000,
                            "easeInExpo",
                            "${TombstoneMain}",
                            '540px',
                            '1081px'
                        ],
                        [
                            "eid50",
                            "boxShadow.color",
                            1130,
                            0,
                            "linear",
                            "${InstaSquare}",
                            'rgba(0,0,0,0.12)',
                            'rgba(0,0,0,0.12)'
                        ],
                        [
                            "eid51",
                            "height",
                            1250,
                            0,
                            "linear",
                            "${TombstoneMain}",
                            '432px',
                            '432px'
                        ],
                        [
                            "eid8",
                            "top",
                            250,
                            1000,
                            "easeOutExpo",
                            "${InstaSquare}",
                            '1150px',
                            '464px'
                        ],
                        [
                            "eid12",
                            "top",
                            2250,
                            1000,
                            "easeInExpo",
                            "${InstaSquare}",
                            '464px',
                            '1150px'
                        ],
                        [
                            "eid49",
                            "boxShadow.blur",
                            1130,
                            0,
                            "linear",
                            "${InstaSquare}",
                            '5px',
                            '5px'
                        ]
                    ]
                }
            }
        };

    AdobeEdge.registerCompositionDefn(compId, symbols, fonts, scripts, resources, opts);

    if (!window.edge_authoring_mode) AdobeEdge.getComposition(compId).load("TS_Twitter_edgeActions.js");
})("EDGE-478761831");
