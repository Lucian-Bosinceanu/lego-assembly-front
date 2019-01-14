import React from "react";
import Button from '@material-ui/core/Button';
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import { Link } from 'react-router-dom'
import CardContent from "@material-ui/core/CardContent"
import CardMedia from "@material-ui/core/CardMedia"
import Grid from "@material-ui/core/Grid";

export class Menu extends React.Component {
  render() {
    return (
        <AppBar 
            position="static"
        > 
            <Toolbar>
                <div id="logo-image">
                    <img src="../../src/media/logo.png"/>
                </div>
                
                <Grid
                    container
                    direction="row"
                    justify="flex-end"
                    alignItems="center"
                    spacing={40}
                >
                <Grid item xs={1}>
                    <Button color="inherit"  component={Link} to="/">Acasă</Button>
                </Grid>

                <Grid item xs={1}>
                    <Button color="inherit"  component={Link} to="/proiect">Proiect</Button>
                </Grid>

                <Grid item xs={1}>
                    <Button color="inherit"  component={Link} to="/module">Module</Button>
                </Grid>

                <Grid item xs={1}>
                    <Button color="inherit"  component={Link} to="/evolutie">Evoluție</Button>
                </Grid>

                <Grid item xs={2}>
                    <Button color="inherit"  component={Link} to="/despre-noi">Despre noi</Button>
                </Grid>

                </Grid>
            </Toolbar>
        </AppBar>      
    );
  }
}
