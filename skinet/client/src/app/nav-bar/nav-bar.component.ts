import {Component, OnInit} from '@angular/core';
import {MegaMenuItem, MenuItem} from "primeng/api";

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.css',
})
export class NavBarComponent implements OnInit {
  public items: MenuItem[] | undefined;
    ngOnInit(): void {
      this.items = [
        {
          label: 'Home',
          icon: 'pi pi-home'
        },
        {
          label: 'Features',
          icon: 'pi pi-star'
        },
        {
          label: 'Projects',
          icon: 'pi pi-search',
          items: [
            {
              label: 'Components',
              icon: 'pi pi-bolt'
            },
            {
              label: 'Blocks',
              icon: 'pi pi-server'
            },
            {
              label: 'UI Kit',
              icon: 'pi pi-pencil'
            },
            {
              label: 'Templates',
              icon: 'pi pi-palette',
              items: [
                {
                  label: 'Apollo',
                  icon: 'pi pi-palette'
                },
                {
                  label: 'Ultima',
                  icon: 'pi pi-palette'
                }
              ]
            }
          ]
        },
        {
          label: 'Contact',
          icon: 'pi pi-envelope'
        }
      ]
    }

}
