import React from "react";
import { Switch, Route } from "react-router-dom"

import {HomePage} from "../pages/HomePage"
import { EvolutionPage } from "../pages/evolution/EvolutionPage";
import { ModulePage } from "../pages/module/ModulePage";
import { AboutUsPage } from "../pages/AboutUsPage";
import { NotFoundPage } from "../pages/NotFoundPage";
import { ProjectPage } from "../pages/ProjectPage";

export class Content extends React.Component {
  render() {
    return (
        <main id="main">
            <Switch>
                <Route exact path="/" component={HomePage} />
                <Route exact path="/proiect" component={ProjectPage} />
                <Route exact path="/evolutie" component={EvolutionPage} />
                <Route exact path="/module" component={ModulePage} />
                <Route exact path="/despre-noi" component={AboutUsPage} />
                <Route component={NotFoundPage} />
            </Switch>
        </main>
    );
  }
}
