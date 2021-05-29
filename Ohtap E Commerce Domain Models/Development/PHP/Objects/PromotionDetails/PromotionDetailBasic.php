<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;



use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;

class PromotionDetailBasic implements IPromotionData
{

    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $Name;

}