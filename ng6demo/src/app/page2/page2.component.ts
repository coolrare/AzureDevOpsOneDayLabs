import { Component, OnInit } from '@angular/core';
import { AppInsightsService } from '@markpieszak/ng-application-insights';
import { Router } from '@angular/router';

@Component({
  selector: 'app-page2',
  templateUrl: './page2.component.html',
  styleUrls: ['./page2.component.css']
})
export class Page2Component implements OnInit {

  constructor(private appInsightsService: AppInsightsService, private router: Router) {}

  ngOnInit() {
    this.appInsightsService.trackPageView('Page1', this.router.url, { 'type': 'PageView' }, { page_count: 1 });
  }

}
