<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Taxs;

class Tax  implements ITax
{

    public $Value;
    public $ID;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;
}