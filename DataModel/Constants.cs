﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public static class Constants
    {
        public static int E_NO_SS_ERR = 0; ///< No error.
        public static int E_NOT_INITIALIZED = -18; ///< Attempt to use something that is not yet initialized.
        public static int E_IS_INITIALIZED = -19; ///< Attempt to initialize something that has already been initialized.
        public static int E_GET_SEMAPHORE_FAILED = -20; ///< Failed to obtain semaphore for subsystem communication.
        public static int E_INDEX_ERROR = -22; ///< Incorrect index specified.
        public static int E_BITRATE_INPUT_ERROR = -23; ///< Failed to set the bitrate of the TRXUV.
        public static int E_CWCHAR_INPUT_ERROR = -24; ///< Failed to set the cwcharrate of the TRXUV.
        public static int E_IDLE_STATE_ERROR = -25; ///< Failed to go into idle mode of the TRXUV.
        public static int E_OUTPUT_MODE_ERROR = -26; ///< Failed to go into outmode of the TRXUV.
        public static int E_TRXUV_COMPONENT_ERROR = -27; ///< Failed to choose a device in the TRXUV.
        public static int E_WRONG_ADC_CHANNEL = -28; ///< Failed to choose a correct ADC channel TRXUV.
        public static int E_RESET_SYSTEM = -29; ///< Failed to reset both microcontrollers in the TRXUV.
        public static int E_MEM_ALLOC = -30; ///< Failed to allocate memory.
        public static int E_ATT_ERROR = -31; ///< Failed to set attenuation value  in the TXS.
        public static int E_PARAM_OUTOFBOUNDS = -32; ///< Failed to set attenuation value  in the TXS.
        public static int E_TRXUV_FRAME_LENGTH = -33; ///< Input frame lenght was greater than the maximum frame length of TRXUV.
        public static int E_INPUT_POINTER_NULL = -34; ///< A pointer input to the function is NULL.
        public static int E_COMMAND_NACKED = -35; ///< A pointer input to the function is NULL.

        /** our errors **/
        public static int E_INVALID_INPUT = -36; ///< Invalid input.
        public static int E_INVALID_ACTION = -37; ///< Invalid action.

        //public Dictionary<int, string> = {<0, "E_NO_SS_ERR">}
        public static Dictionary<int, string> MapIdToError = new Dictionary<int, string>
        {
            {0, "No Error :E_NO_SS_ERR" },
            {-18, "ERROR: E_NOT_INITIALIZED"},
            {-19, "ERROR: E_IS_INITIALIZED" },
            {-20,  "ERROR: E_GET_SEMAPHORE_FAILED"},
            {-22,  "ERROR: E_INDEX_ERROR"},
            {-23, "ERROR: E_BITRATE_INPUT_ERROR" },
            {-24, "ERROR: E_CWCHAR_INPUT_ERROR" },
            {-25, "ERROR: E_IDLE_STATE_ERROR" },
            {-26, "ERROR: E_OUTPUT_MODE_ERROR" },
            {-27, "ERROR: E_TRXUV_COMPONENT_ERROR" },
            {-28, "ERROR: E_WRONG_ADC_CHANNEL" },
            {-29, "ERROR: E_RESET_SYSTEM" },
            {-30, "ERROR: E_MEM_ALLOC" },
            {-31, "ERROR: E_ATT_ERROR" },
            {-32, "ERROR: E_PARAM_OUTOFBOUNDS" },
            {-33, "ERROR: E_TRXUV_FRAME_LENGTH" },
            {-34, "ERROR: E_INPUT_POINTER_NULL" },
            {-35, "ERROR: E_COMMAND_NACKED" },
            {-36, "ERROR: E_INVALID_INPUT" },
            {-37, "ERROR: E_INVALID_ACTION" }
    };
    }
}
