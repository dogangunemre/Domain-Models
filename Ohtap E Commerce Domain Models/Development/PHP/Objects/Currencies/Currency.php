<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Currencies;


use Ohtap\ECommerce\DomainModels\Objects\CurrencyDetail\ICurrencyDetail;

class Currency extends CurrencyBasic implements ICurrency
{
    public ICurrencyDetail  $Details;
}
