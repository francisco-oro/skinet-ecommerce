import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";
import {NavBarComponent} from './components/nav-bar/nav-bar.component';
import {MegaMenuModule} from "primeng/megamenu";
import {MenubarModule} from "primeng/menubar";
import {NgOptimizedImage} from "@angular/common";
import {ButtonModule} from "primeng/button";
import {RippleModule} from "primeng/ripple";
import {TagModule} from "primeng/tag";
import {MenuBarComponent} from './components/menu-bar/menu-bar.component';
import {SearchBarComponent} from './components/search-bar/search-bar.component';
import { AutoCompleteModule} from "primeng/autocomplete";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {HttpClientModule} from "@angular/common/http";
import {DropdownModule} from "primeng/dropdown";

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    MenuBarComponent,
    SearchBarComponent,
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
    TagModule,
    MenubarModule,
    AutoCompleteModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    DropdownModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
