<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Feedbacks;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IFeedbackData extends IFeedbackTypes,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
