<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Brands;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


//Logo için IFileData extends edilecek

interface IBrandData extends  CoreObjects\IObjectID,IBrandLogo, CoreObjects\IObjectCode, CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}