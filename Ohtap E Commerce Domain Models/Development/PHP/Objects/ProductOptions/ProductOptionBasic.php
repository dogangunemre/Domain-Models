<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;




use Ohtap\ECommerce\DomainModels\Objects\Options\IOptionData;

class ProductOptionBasic implements IProductOptionData
{

    public string $Description;
    public IOptionData $Option;
    public string $Value;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public string $ID;

}