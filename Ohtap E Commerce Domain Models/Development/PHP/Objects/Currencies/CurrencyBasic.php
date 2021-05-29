<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Currencies;





class CurrencyBasic implements ICurrencyData
{
    public string $ID;
    public string $Symbol;
    public  string $FundCode;
    public string $Name;
    public int $State;
    public int $OrderNo;
    public string $Description;
}
