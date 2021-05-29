<?php

namespace Ohtap\ECommerce\DomainModels\Objects\PackageOptions;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;



interface IPackageOptionData extends IPackageOptionOption,IPackageOptionValue,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
