<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Currencies;



class CurrencyDetailBasic implements ICurrencyDetailData
{
    public $ID;
    public $Symbol;
    public $FundCode;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;
}