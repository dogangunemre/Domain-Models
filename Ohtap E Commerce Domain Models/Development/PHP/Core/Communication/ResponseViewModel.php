<?php
namespace Ohtap\ECommerce\DomainModels\Core\Communication;

class ResponseViewModel implements IResponseViewModel
{
    public  $RequestData;
    public  $ResponseData;
    public  $Messages;
    public  $State;

    public function __construct($RequestData)
    {
        $this->RequestData = $RequestData;
    }
}






