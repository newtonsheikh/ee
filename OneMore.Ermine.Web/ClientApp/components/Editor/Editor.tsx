import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Editor extends React.Component<RouteComponentProps<{}>, any> {
    constructor() {
        super();
    }
    render() {
        return (
            <div>here will sit the editor</div>
            // <Wrapper>Canvas</Wrapper>
        );
    }

} 