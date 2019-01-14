import React from "react";
import BottomNavigation from '@material-ui/core/BottomNavigation';
import BottomNavigationAction from '@material-ui/core/BottomNavigationAction';
import Icon from '@material-ui/core/Icon';

export class Footer extends React.Component {
  
    constructor(props) {
        super(props);

        this.handleChange = this.handleChange.bind(this);
    }

    handleChange(event, newValue) {
        window.open(newValue);
    }
    
    render() {
    return (
        <footer>
            <BottomNavigation
                value={500}
                onChange={this.handleChange}
                showLabels
            >
                <BottomNavigationAction value="https://github.com/Lucian-Bosinceanu/lego-assembly-front" label="Front repo" icon={<Icon>web</Icon>} />
                <BottomNavigationAction value="https://github.com/Lucian-Bosinceanu/lego-assembly-back" label="Back repo" icon={<Icon>web</Icon>} />
                <BottomNavigationAction value="https://tinyurl.com/ydxjhxxg" label="Fișa proiect" icon={<Icon>web</Icon>} />
            </BottomNavigation>
      </footer>
    );
  }
}
