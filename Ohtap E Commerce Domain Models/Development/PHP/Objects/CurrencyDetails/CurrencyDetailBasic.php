<?php
namespace Ohtap\ECommerce\DomainModels\Objects\CurrencyDetail;



class CurrencyDetailBasic implements ICurrencyDetailData
{
    public string $ID;
    public string $Name;
    public int $State;
    public int $OrderNo;
    public string $Description;
}