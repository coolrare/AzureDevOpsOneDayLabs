import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ApplicationInsightsModule, AppInsightsService } from '@markpieszak/ng-application-insights';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ApplicationInsightsModule.forRoot({
      instrumentationKey: 'ac686484-1007-4bd5-ab73-48ca32777907'
    })
  ],
  providers: [AppInsightsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
