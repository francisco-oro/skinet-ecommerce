import {Component, OnInit} from '@angular/core';
import {MegaMenuItem} from "primeng/api";

@Component({
    selector: 'app-menu-bar',
    templateUrl: './menu-bar.component.html',
    styleUrl: './menu-bar.component.css'
})
export class MenuBarComponent implements OnInit {

    public items: MegaMenuItem[] | undefined;

    ngOnInit(): void {
        this.items = [
            {
                label: 'Home',
                icon: 'pi pi-box',
                root: true,
                items: [
                    [
                        {
                            label: 'Living Room',
                            items: [{label: 'Accessories'}, {label: 'Armchair'}, {label: 'Coffee Table'}, {label: 'Couch'}, {label: 'TV Stand'}]
                        }
                    ],
                    [
                        {
                            label: 'Kitchen',
                            items: [{label: 'Bar stool'}, {label: 'Chair'}, {label: 'Table'}]
                        },
                        {
                            label: 'Bathroom',
                            items: [{label: 'Accessories'}]
                        }
                    ],
                    [
                        {
                            label: 'Bedroom',
                            items: [{label: 'Bed'}, {label: 'Chaise lounge'}, {label: 'Cupboard'}, {label: 'Dresser'}, {label: 'Wardrobe'}]
                        }
                    ],
                    [
                        {
                            label: 'Office',
                            items: [{label: 'Bookcase'}, {label: 'Cabinet'}, {label: 'Chair'}, {label: 'Desk'}, {label: 'Executive Chair'}]
                        }
                    ]
                ]
            },
            {
                label: 'Shop',
                icon: 'pi pi-mobile',
                root: true,
                items: [
                    [
                        {
                            label: 'Computer',
                            items: [{label: 'Monitor'}, {label: 'Mouse'}, {label: 'Notebook'}, {label: 'Keyboard'}, {label: 'Printer'}, {label: 'Storage'}]
                        }
                    ],
                    [
                        {
                            label: 'Home Theather',
                            items: [{label: 'Projector'}, {label: 'Speakers'}, {label: 'TVs'}]
                        }
                    ],
                    [
                        {
                            label: 'Gaming',
                            items: [{label: 'Accessories'}, {label: 'Console'}, {label: 'PC'}, {label: 'Video Games'}]
                        }
                    ],
                    [
                        {
                            label: 'Appliances',
                            items: [{label: 'Coffee Machine'}, {label: 'Fridge'}, {label: 'Oven'}, {label: 'Vaccum Cleaner'}, {label: 'Washing Machine'}]
                        }
                    ]
                ]
            },
            {
                label: 'Contact',
                icon: 'pi pi-clock',
                root: true,
                items: [
                    [
                        {
                            label: 'Football',
                            items: [{label: 'Kits'}, {label: 'Shoes'}, {label: 'Shorts'}, {label: 'Training'}]
                        }
                    ],
                    [
                        {
                            label: 'Running',
                            items: [{label: 'Accessories'}, {label: 'Shoes'}, {label: 'T-Shirts'}, {label: 'Shorts'}]
                        }
                    ],
                    [
                        {
                            label: 'Swimming',
                            items: [{label: 'Kickboard'}, {label: 'Nose Clip'}, {label: 'Swimsuits'}, {label: 'Paddles'}]
                        }
                    ],
                    [
                        {
                            label: 'Tennis',
                            items: [{label: 'Balls'}, {label: 'Rackets'}, {label: 'Shoes'}, {label: 'Training'}]
                        }
                    ]
                ]
            }
        ]

    }

}
