<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Products;


use Ohtap\ECommerce\DomainModels\Objects\Attributes\IAttributeDataList;
use Ohtap\ECommerce\DomainModels\Objects\Brands\IBrandData;
use Ohtap\ECommerce\DomainModels\Objects\Categories\ICategoryDataList;
use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;
use Ohtap\ECommerce\DomainModels\Objects\Feedbacks\IFeedbackDataList;
use Ohtap\ECommerce\DomainModels\Objects\Files\IFileDataList;
use Ohtap\ECommerce\DomainModels\Objects\Manifacturers\IManifacturerData;
use Ohtap\ECommerce\DomainModels\Objects\Measures\IMeasureDataList;
use Ohtap\ECommerce\DomainModels\Objects\Prices\IPriceDataList;
use Ohtap\ECommerce\DomainModels\Objects\Promotions\IProductLabelDataList;
use Ohtap\ECommerce\DomainModels\Objects\Promotions\IProductOptionDataList;
use Ohtap\ECommerce\DomainModels\Objects\Promotions\IProductSpecificationDataList;
use Ohtap\ECommerce\DomainModels\Objects\Taxs\ITaxData;

use Ohtap\ECommerce\DomainModels\Objects\Warehouses\IWarehouseDataList;


class Product  implements IProduct
{

    public IDiscountData $Discount;
    public ITaxData $Tax;
    public IBrandData $Brand;
    public IFileDataList $Photos;
    public IPriceDataList $Prices;
    public IMeasureDataList $Measures;
    public IWarehouseDataList $Warehouses;
    public IProductDetailDataList $Details;
    public IProductOptionDataList $Options;
    public IProductLabelDataList $Labels;
    public IProductSpecificationDataList $Specifications;
    public ICategoryDataList $Categories;
    public IAttributeDataList $Attributes;
    public IFeedbackDataList $Feedbacks;
    public IManifacturerData $Manifacturer;
    public string $Description;
    public string $Barcode;
    public string $SKU;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public int $ID;

}