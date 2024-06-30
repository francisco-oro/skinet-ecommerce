import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import {MegaMenuModule} from "primeng/megamenu";
import {MenubarModule} from "primeng/menubar";
import {NgOptimizedImage} from "@angular/common";
import { ButtonModule} from "primeng/button";
import {RippleModule} from "primeng/ripple";
import {TagModule} from "primeng/tag";
import { MenuBarComponent } from './components/menu-bar/menu-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    MenuBarComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    MegaMenuModule,
    MenubarModule,
    NgOptimizedImage,
    ButtonModule,
    RippleModule,
    TagModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
