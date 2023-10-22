﻿using CleanArchitecture.WebUI.Models;
using CleanArchitecture.WebUI.Models.DTOs;
using CleanArchitecture.WebUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CleanArchitecture.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IChartService _chartService;

        public DashboardController(IChartService chartService)
        {
            _chartService = chartService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetMemberAndBookingLineChartData()
        {
            ResponseDTO? response = await _chartService.GetMemberAndBookingLineChart();
            if(response is not null && response.IsSuccess)
            {
                LineChart lineChart = JsonConvert.DeserializeObject<LineChart>(response.Result.ToString());
                return Json(lineChart);
            }
            else
            {
                TempData["error"] = response?.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> GetBookingPieChartData()
        {
            ResponseDTO? response = await _chartService.GetBookingPieChart();
            if (response is not null && response.IsSuccess)
            {
                PieChart pieChart = JsonConvert.DeserializeObject<PieChart>(response.Result.ToString());
                return Json(pieChart);
            }
            else
            {
                TempData["error"] = response?.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> GetTotalBookingRadialChartData()
        {
            ResponseDTO? response = await _chartService.GetTotalBookingRadialChart();
            if (response is not null && response.IsSuccess)
            {
                RadialBarChart radialBarChart = JsonConvert.DeserializeObject<RadialBarChart>(response.Result.ToString());
                return Json(radialBarChart);
            }
            else
            {
                TempData["error"] = response?.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> GetRevenueChartData()
        {
            ResponseDTO? response = await _chartService.GetRevenueChart();
            if (response is not null && response.IsSuccess)
            {
                RadialBarChart radialBarChart = JsonConvert.DeserializeObject<RadialBarChart>(response.Result.ToString());
                return Json(radialBarChart);
            }
            else
            {
                TempData["error"] = response?.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> GetRegisteredUserChartData()
        {
            ResponseDTO? response = await _chartService.GetRegisterUserChart();
            if (response is not null && response.IsSuccess)
            {
                RadialBarChart radialBarChart = JsonConvert.DeserializeObject<RadialBarChart>(response.Result.ToString());
                return Json(radialBarChart);
            }
            else
            {
                TempData["error"] = response?.Message;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
