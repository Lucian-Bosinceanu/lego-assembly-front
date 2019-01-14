import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

import {Week_7_component} from "./weeks/Week_7_component"
import {Week_8_component} from "./weeks/Week_8_component"
import {Week_9_component} from "./weeks/Week_9_component"
import {Week_10_component} from "./weeks/Week_10_component"
import {Week_11_component} from "./weeks/Week_11_component"
import {Week_12_component} from "./weeks/Week_12_component"
import {Week_13_component} from "./weeks/Week_13_component"
import {Week_14_component} from "./weeks/Week_14_component"

export class EvolutionPage extends React.Component {
  render() {
    return (
      <div className="content-papers">
        <Paper className={"content"}>
          <Typography variant = "h3" color="inherit" component="h3">
            Evoluția proiectului
          </Typography>
        </Paper>

        <Week_7_component/>
        <Week_8_component/>
        <Week_9_component/>
        <Week_10_component/>
        <Week_11_component/>
        <Week_12_component/>
        <Week_13_component/>
        <Week_14_component/>
        
      </div>
    );
  }
}
