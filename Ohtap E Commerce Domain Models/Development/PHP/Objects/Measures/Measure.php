<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Measures;

class Measure  implements IMeasure
{

    public $Units;//UnitList
    public $Details;//MeasureData
    public $Description;
    public $State;
    public $OrderNo;
    public $Title;
    public $Name;
    public $ID;
}