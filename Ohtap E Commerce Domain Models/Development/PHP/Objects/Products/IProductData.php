<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Products;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IProductData extends IProductBarcode,IProductSKU,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
