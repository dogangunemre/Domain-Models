<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Feedbacks;



class FeedbackBasic implements IFeedbackData
{
    public $FeedbackTypes;//FeedbackTypes class tipinde
    public $ID;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;

}