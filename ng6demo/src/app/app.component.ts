import { Component } from '@angular/core';
import { AppInsightsService } from '@markpieszak/ng-application-insights';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ng6demo';
  constructor(private appInsightsService: AppInsightsService) {}
  clickMe() {
    this.appInsightsService.trackEvent('AppComponent', { 'now': new Date().toUTCString() });
  }
}
