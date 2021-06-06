import React, { Component } from 'react';
import { Application } from './components/Application';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
      return (
        <Application />
    );
  }
}
