//     This code was generated by a Reinforced.Typings tool. 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.

import { Ore } from './Ore';
import { Category } from './Category';

export class ProductType
{
    public id: number;
    public name: string;
    public ore: Ore;
    public category: Category;
    public description: string;
}