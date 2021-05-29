<?php

namespace Ohtap\ECommerce\DomainModels\Objects\LabelDetails;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ILabelDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
