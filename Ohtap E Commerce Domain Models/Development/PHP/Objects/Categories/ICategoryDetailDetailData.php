<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Categories;
use Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ICategoryDetailDetailData extends ICategoryDetailPhoto,ICategoryDetailParent,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{


}