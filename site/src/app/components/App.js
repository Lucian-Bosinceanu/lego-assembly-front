import React from "react";
import Grid from "@material-ui/core/Grid"

import { Menu } from "./Menu";
import { Footer } from "./Footer";
import { Content } from "./Content";

export class App extends React.Component {
  render() {
    return (
      <Grid 
        container
        justify="center" 
        spacing={0}
      >

        <Grid item xs={12}>
          <Menu/>
        </Grid>

        <Grid item xs={11}>
          <Content/>
        </Grid>

        <Grid item xs={12}>
          <Footer/>
        </Grid>
      </Grid>
    );
  }
}
