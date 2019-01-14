import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

import {FrontTable} from "./tables/FrontTable"
import { BackTable } from "./tables/BackTable";
import { TestTable } from "./tables/TestTable";

export class ModulePage extends React.Component {
  render() {
    return (
      <div className="content-papers">
        <Paper className={"content"}>
          <Typography variant = "h3" color="inherit" component="h3">
            Distribuția inițială a membrilor pe submodule
          </Typography>
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Front-end
          </Typography>

          <FrontTable />
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Back-end
          </Typography>
        
          <BackTable/>
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Testare
          </Typography>
      
          <TestTable/>
        </Paper>
      </div>
    );
  }
}
