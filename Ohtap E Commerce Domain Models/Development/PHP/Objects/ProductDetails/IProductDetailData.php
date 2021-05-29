<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Products;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IProductDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
