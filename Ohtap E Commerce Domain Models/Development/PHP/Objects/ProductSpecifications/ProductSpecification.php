<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;


use Ohtap\ECommerce\DomainModels\Objects\Specifications\ISpecificationData;


class ProductSpecification  implements IProductSpecification
{

    public string $Description;
    public ISpecificationData $Specification;
    public string $Value;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public string $ID;

}