import {Component} from 'angular2/core';
import {RouteParams, Router} from 'angular2/router';

@Component({
    templateUrl: 'app/news/news-detail.component.html'
})

export class NewsDetailComponent{
    pageTitle: string = 'Detail news' ;
    constructor(private _routeParams: RouteParams, private _router: Router){
        let id = +this._routeParams.get('id');
        //this.pageTitle += `: ${id}`;
    }

    onBack() : void{
        this._router.navigate(['News']);
    }
}

