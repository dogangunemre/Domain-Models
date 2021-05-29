<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Feedbacks;

class Feedback  implements IFeedback
{

    public $Customers;//CustomerBasic
    public $FeedbackTypes;//FeedbackTypes class tipinde
    public $ID;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;
}