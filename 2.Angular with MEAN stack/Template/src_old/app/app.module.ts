import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { MarvellousComponent } from './marvellous/marvellous.component';
import { InfosystemComponent } from './infosystem/infosystem.component';

@NgModule({
  declarations: [
    AppComponent,
    MarvellousComponent,
    InfosystemComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
