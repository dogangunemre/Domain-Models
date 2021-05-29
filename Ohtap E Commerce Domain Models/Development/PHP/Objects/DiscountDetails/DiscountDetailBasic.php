<?php
namespace Ohtap\ECommerce\DomainModels\Objects\DiscountDetail;



class DiscountDetailBasic implements IDiscountDetailData
{
    public string $ID;
    public string $Name;
    public int $State;
    public int $OrderNo;
    public string $Description;
}