/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Live.V20180801
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Live.V20180801.Models;

   public class LiveClient : AbstractClient{

       private const string endpoint = "live.tencentcloudapi.com";
       private const string version = "2018-08-01";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public LiveClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public LiveClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 对流设置延播时间
        /// 注意：如果在推流前设置延播，需要提前5分钟设置。
        /// </summary>
        /// <param name="req">参考<see cref="AddDelayLiveStreamRequest"/></param>
        /// <returns>参考<see cref="AddDelayLiveStreamResponse"/>实例</returns>
        public async Task<AddDelayLiveStreamResponse> AddDelayLiveStream(AddDelayLiveStreamRequest req)
        {
             JsonResponseModel<AddDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加水印
        /// </summary>
        /// <param name="req">参考<see cref="AddLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="AddLiveWatermarkResponse"/>实例</returns>
        public async Task<AddLiveWatermarkResponse> AddLiveWatermark(AddLiveWatermarkRequest req)
        {
             JsonResponseModel<AddLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 域名绑定证书
        /// </summary>
        /// <param name="req">参考<see cref="BindLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="BindLiveDomainCertResponse"/>实例</returns>
        public async Task<BindLiveDomainCertResponse> BindLiveDomainCert(BindLiveDomainCertRequest req)
        {
             JsonResponseModel<BindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建回调规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveCallbackRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveCallbackRuleResponse"/>实例</returns>
        public async Task<CreateLiveCallbackRuleResponse> CreateLiveCallbackRule(CreateLiveCallbackRuleRequest req)
        {
             JsonResponseModel<CreateLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建回调模板
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveCallbackTemplateResponse"/>实例</returns>
        public async Task<CreateLiveCallbackTemplateResponse> CreateLiveCallbackTemplate(CreateLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<CreateLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加证书
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveCertRequest"/></param>
        /// <returns>参考<see cref="CreateLiveCertResponse"/>实例</returns>
        public async Task<CreateLiveCertResponse> CreateLiveCert(CreateLiveCertRequest req)
        {
             JsonResponseModel<CreateLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// - 使用前提
        ///   1. 录制文件存放于点播平台，所以用户如需使用录制功能，需首先自行开通点播服务。
        ///   2. 录制文件存放后相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，具体请参考 [对应文档](https://cloud.tencent.com/document/product/266/2838)。
        /// 
        /// - 模式说明
        ///   该接口支持两种录制模式：
        ///   1. 定时录制模式。
        ///     需要传入开始时间与结束时间，录制任务根据时间自动开始与结束。
        ///   2. 实时视频录制模式。
        ///     忽略传入的开始时间，在录制任务创建后立即开始录制，录制时长支持最大为30分钟，如果传入的结束时间与当前时间差大于30分钟，则按30分钟计算，实时视频录制主要用于录制精彩视频场景，时长建议控制在5分钟以内。
        /// 
        /// - 注意事项
        ///   1. 调用接口超时设置应大于3秒，小于3秒重试以及频繁调用都有可能产生重复录制任务。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveRecordRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordResponse"/>实例</returns>
        public async Task<CreateLiveRecordResponse> CreateLiveRecord(CreateLiveRecordRequest req)
        {
             JsonResponseModel<CreateLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建录制规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveRecordRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordRuleResponse"/>实例</returns>
        public async Task<CreateLiveRecordRuleResponse> CreateLiveRecordRule(CreateLiveRecordRuleRequest req)
        {
             JsonResponseModel<CreateLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建录制模板
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveRecordTemplateResponse"/>实例</returns>
        public async Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplate(CreateLiveRecordTemplateRequest req)
        {
             JsonResponseModel<CreateLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建截图规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveSnapshotRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveSnapshotRuleResponse"/>实例</returns>
        public async Task<CreateLiveSnapshotRuleResponse> CreateLiveSnapshotRule(CreateLiveSnapshotRuleRequest req)
        {
             JsonResponseModel<CreateLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建截图模板
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveSnapshotTemplateResponse"/>实例</returns>
        public async Task<CreateLiveSnapshotTemplateResponse> CreateLiveSnapshotTemplate(CreateLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转码规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveTranscodeRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveTranscodeRuleResponse"/>实例</returns>
        public async Task<CreateLiveTranscodeRuleResponse> CreateLiveTranscodeRule(CreateLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转码模板
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateLiveTranscodeTemplateResponse"/>实例</returns>
        public async Task<CreateLiveTranscodeTemplateResponse> CreateLiveTranscodeTemplate(CreateLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建水印规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateLiveWatermarkRuleRequest"/></param>
        /// <returns>参考<see cref="CreateLiveWatermarkRuleResponse"/>实例</returns>
        public async Task<CreateLiveWatermarkRuleResponse> CreateLiveWatermarkRule(CreateLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<CreateLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加拉流配置，目前限制添加10条任务。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="CreatePullStreamConfigResponse"/>实例</returns>
        public async Task<CreatePullStreamConfigResponse> CreatePullStreamConfig(CreatePullStreamConfigRequest req)
        {
             JsonResponseModel<CreatePullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除回调规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveCallbackRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveCallbackRuleResponse"/>实例</returns>
        public async Task<DeleteLiveCallbackRuleResponse> DeleteLiveCallbackRule(DeleteLiveCallbackRuleRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveCallbackRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除回调模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveCallbackTemplateResponse"/>实例</returns>
        public async Task<DeleteLiveCallbackTemplateResponse> DeleteLiveCallbackTemplate(DeleteLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名对应的证书
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveCertRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveCertResponse"/>实例</returns>
        public async Task<DeleteLiveCertResponse> DeleteLiveCert(DeleteLiveCertRequest req)
        {
             JsonResponseModel<DeleteLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除录制任务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordResponse"/>实例</returns>
        public async Task<DeleteLiveRecordResponse> DeleteLiveRecord(DeleteLiveRecordRequest req)
        {
             JsonResponseModel<DeleteLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除录制规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordRuleResponse"/>实例</returns>
        public async Task<DeleteLiveRecordRuleResponse> DeleteLiveRecordRule(DeleteLiveRecordRuleRequest req)
        {
             JsonResponseModel<DeleteLiveRecordRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecordRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除录制模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveRecordTemplateResponse"/>实例</returns>
        public async Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplate(DeleteLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除截图规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveSnapshotRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveSnapshotRuleResponse"/>实例</returns>
        public async Task<DeleteLiveSnapshotRuleResponse> DeleteLiveSnapshotRule(DeleteLiveSnapshotRuleRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveSnapshotRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除截图模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveSnapshotTemplateResponse"/>实例</returns>
        public async Task<DeleteLiveSnapshotTemplateResponse> DeleteLiveSnapshotTemplate(DeleteLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除转码规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveTranscodeRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveTranscodeRuleResponse"/>实例</returns>
        public async Task<DeleteLiveTranscodeRuleResponse> DeleteLiveTranscodeRule(DeleteLiveTranscodeRuleRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveTranscodeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除转码模板
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveTranscodeTemplateResponse"/>实例</returns>
        public async Task<DeleteLiveTranscodeTemplateResponse> DeleteLiveTranscodeTemplate(DeleteLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除水印
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveWatermarkResponse"/>实例</returns>
        public async Task<DeleteLiveWatermarkResponse> DeleteLiveWatermark(DeleteLiveWatermarkRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除水印规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLiveWatermarkRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteLiveWatermarkRuleResponse"/>实例</returns>
        public async Task<DeleteLiveWatermarkRuleResponse> DeleteLiveWatermarkRule(DeleteLiveWatermarkRuleRequest req)
        {
             JsonResponseModel<DeleteLiveWatermarkRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveWatermarkRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveWatermarkRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除直播拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="DeletePullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="DeletePullStreamConfigResponse"/>实例</returns>
        public async Task<DeletePullStreamConfigResponse> DeletePullStreamConfig(DeletePullStreamConfigRequest req)
        {
             JsonResponseModel<DeletePullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取回调规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCallbackRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCallbackRulesResponse"/>实例</returns>
        public async Task<DescribeLiveCallbackRulesResponse> DescribeLiveCallbackRules(DescribeLiveCallbackRulesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCallbackRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个回调模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCallbackTemplateResponse"/>实例</returns>
        public async Task<DescribeLiveCallbackTemplateResponse> DescribeLiveCallbackTemplate(DescribeLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取回调模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCallbackTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCallbackTemplatesResponse"/>实例</returns>
        public async Task<DescribeLiveCallbackTemplatesResponse> DescribeLiveCallbackTemplates(DescribeLiveCallbackTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveCallbackTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCallbackTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCallbackTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCertRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCertResponse"/>实例</returns>
        public async Task<DescribeLiveCertResponse> DescribeLiveCert(DescribeLiveCertRequest req)
        {
             JsonResponseModel<DescribeLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveCertsRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveCertsResponse"/>实例</returns>
        public async Task<DescribeLiveCertsResponse> DescribeLiveCerts(DescribeLiveCertsRequest req)
        {
             JsonResponseModel<DescribeLiveCertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名证书信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveDomainCertResponse"/>实例</returns>
        public async Task<DescribeLiveDomainCertResponse> DescribeLiveDomainCert(DescribeLiveDomainCertRequest req)
        {
             JsonResponseModel<DescribeLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询播放鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLivePlayAuthKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeLivePlayAuthKeyResponse"/>实例</returns>
        public async Task<DescribeLivePlayAuthKeyResponse> DescribeLivePlayAuthKey(DescribeLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询直播推流鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLivePushAuthKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeLivePushAuthKeyResponse"/>实例</returns>
        public async Task<DescribeLivePushAuthKeyResponse> DescribeLivePushAuthKey(DescribeLivePushAuthKeyRequest req)
        {
             JsonResponseModel<DescribeLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取录制规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveRecordRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveRecordRulesResponse"/>实例</returns>
        public async Task<DescribeLiveRecordRulesResponse> DescribeLiveRecordRules(DescribeLiveRecordRulesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个录制模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveRecordTemplateResponse"/>实例</returns>
        public async Task<DescribeLiveRecordTemplateResponse> DescribeLiveRecordTemplate(DescribeLiveRecordTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取录制模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveRecordTemplatesResponse"/>实例</returns>
        public async Task<DescribeLiveRecordTemplatesResponse> DescribeLiveRecordTemplates(DescribeLiveRecordTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveRecordTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取截图规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveSnapshotRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveSnapshotRulesResponse"/>实例</returns>
        public async Task<DescribeLiveSnapshotRulesResponse> DescribeLiveSnapshotRules(DescribeLiveSnapshotRulesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveSnapshotRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个截图模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveSnapshotTemplateResponse"/>实例</returns>
        public async Task<DescribeLiveSnapshotTemplateResponse> DescribeLiveSnapshotTemplate(DescribeLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取截图模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveSnapshotTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveSnapshotTemplatesResponse"/>实例</returns>
        public async Task<DescribeLiveSnapshotTemplatesResponse> DescribeLiveSnapshotTemplates(DescribeLiveSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询在线推流信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamOnlineInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamOnlineInfoResponse"/>实例</returns>
        public async Task<DescribeLiveStreamOnlineInfoResponse> DescribeLiveStreamOnlineInfo(DescribeLiveStreamOnlineInfoRequest req)
        {
             JsonResponseModel<DescribeLiveStreamOnlineInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamOnlineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamOnlineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回正在直播中的流列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamOnlineListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamOnlineListResponse"/>实例</returns>
        public async Task<DescribeLiveStreamOnlineListResponse> DescribeLiveStreamOnlineList(DescribeLiveStreamOnlineListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamOnlineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamOnlineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamOnlineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回已经推过流的流列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamPublishedListRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamPublishedListResponse"/>实例</returns>
        public async Task<DescribeLiveStreamPublishedListResponse> DescribeLiveStreamPublishedList(DescribeLiveStreamPublishedListRequest req)
        {
             JsonResponseModel<DescribeLiveStreamPublishedListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamPublishedList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamPublishedListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回直播中、无推流或者禁播等状态
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveStreamStateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveStreamStateResponse"/>实例</returns>
        public async Task<DescribeLiveStreamStateResponse> DescribeLiveStreamState(DescribeLiveStreamStateRequest req)
        {
             JsonResponseModel<DescribeLiveStreamStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStreamState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取转码规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeRulesResponse"/>实例</returns>
        public async Task<DescribeLiveTranscodeRulesResponse> DescribeLiveTranscodeRules(DescribeLiveTranscodeRulesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个转码模板
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeTemplateResponse"/>实例</returns>
        public async Task<DescribeLiveTranscodeTemplateResponse> DescribeLiveTranscodeTemplate(DescribeLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取转码模板列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveTranscodeTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveTranscodeTemplatesResponse"/>实例</returns>
        public async Task<DescribeLiveTranscodeTemplatesResponse> DescribeLiveTranscodeTemplates(DescribeLiveTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeLiveTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个水印信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarkResponse"/>实例</returns>
        public async Task<DescribeLiveWatermarkResponse> DescribeLiveWatermark(DescribeLiveWatermarkRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取水印规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarkRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarkRulesResponse"/>实例</returns>
        public async Task<DescribeLiveWatermarkRulesResponse> DescribeLiveWatermarkRules(DescribeLiveWatermarkRulesRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarkRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermarkRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarkRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询水印列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLiveWatermarksRequest"/></param>
        /// <returns>参考<see cref="DescribeLiveWatermarksResponse"/>实例</returns>
        public async Task<DescribeLiveWatermarksResponse> DescribeLiveWatermarks(DescribeLiveWatermarksRequest req)
        {
             JsonResponseModel<DescribeLiveWatermarksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveWatermarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveWatermarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribePullStreamConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribePullStreamConfigsResponse"/>实例</returns>
        public async Task<DescribePullStreamConfigsResponse> DescribePullStreamConfigs(DescribePullStreamConfigsRequest req)
        {
             JsonResponseModel<DescribePullStreamConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePullStreamConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePullStreamConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 断开推流连接，但可以重新推流
        /// </summary>
        /// <param name="req">参考<see cref="DropLiveStreamRequest"/></param>
        /// <returns>参考<see cref="DropLiveStreamResponse"/>实例</returns>
        public async Task<DropLiveStreamResponse> DropLiveStream(DropLiveStreamRequest req)
        {
             JsonResponseModel<DropLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DropLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// </summary>
        /// <param name="req">参考<see cref="ForbidLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ForbidLiveStreamResponse"/>实例</returns>
        public async Task<ForbidLiveStreamResponse> ForbidLiveStream(ForbidLiveStreamRequest req)
        {
             JsonResponseModel<ForbidLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForbidLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改回调模板
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveCallbackTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveCallbackTemplateResponse"/>实例</returns>
        public async Task<ModifyLiveCallbackTemplateResponse> ModifyLiveCallbackTemplate(ModifyLiveCallbackTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveCallbackTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveCallbackTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCallbackTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改证书
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveCertRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveCertResponse"/>实例</returns>
        public async Task<ModifyLiveCertResponse> ModifyLiveCert(ModifyLiveCertRequest req)
        {
             JsonResponseModel<ModifyLiveCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名和证书绑定信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveDomainCertResponse"/>实例</returns>
        public async Task<ModifyLiveDomainCertResponse> ModifyLiveDomainCert(ModifyLiveDomainCertRequest req)
        {
             JsonResponseModel<ModifyLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改播放鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePlayAuthKeyRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePlayAuthKeyResponse"/>实例</returns>
        public async Task<ModifyLivePlayAuthKeyResponse> ModifyLivePlayAuthKey(ModifyLivePlayAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePlayAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePlayAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePlayAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改直播推流鉴权key
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLivePushAuthKeyRequest"/></param>
        /// <returns>参考<see cref="ModifyLivePushAuthKeyResponse"/>实例</returns>
        public async Task<ModifyLivePushAuthKeyResponse> ModifyLivePushAuthKey(ModifyLivePushAuthKeyRequest req)
        {
             JsonResponseModel<ModifyLivePushAuthKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLivePushAuthKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLivePushAuthKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改录制模板配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveRecordTemplateResponse"/>实例</returns>
        public async Task<ModifyLiveRecordTemplateResponse> ModifyLiveRecordTemplate(ModifyLiveRecordTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改截图模板配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveSnapshotTemplateResponse"/>实例</returns>
        public async Task<ModifyLiveSnapshotTemplateResponse> ModifyLiveSnapshotTemplate(ModifyLiveSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改转码模板配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLiveTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyLiveTranscodeTemplateResponse"/>实例</returns>
        public async Task<ModifyLiveTranscodeTemplateResponse> ModifyLiveTranscodeTemplate(ModifyLiveTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyLiveTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新拉流配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPullStreamConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyPullStreamConfigResponse"/>实例</returns>
        public async Task<ModifyPullStreamConfigResponse> ModifyPullStreamConfig(ModifyPullStreamConfigRequest req)
        {
             JsonResponseModel<ModifyPullStreamConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPullStreamConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPullStreamConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改直播拉流配置状态
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPullStreamStatusRequest"/></param>
        /// <returns>参考<see cref="ModifyPullStreamStatusResponse"/>实例</returns>
        public async Task<ModifyPullStreamStatusResponse> ModifyPullStreamStatus(ModifyPullStreamStatusRequest req)
        {
             JsonResponseModel<ModifyPullStreamStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPullStreamStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPullStreamStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复延迟播放设置
        /// </summary>
        /// <param name="req">参考<see cref="ResumeDelayLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ResumeDelayLiveStreamResponse"/>实例</returns>
        public async Task<ResumeDelayLiveStreamResponse> ResumeDelayLiveStream(ResumeDelayLiveStreamRequest req)
        {
             JsonResponseModel<ResumeDelayLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeDelayLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeDelayLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复某条流的推送。
        /// </summary>
        /// <param name="req">参考<see cref="ResumeLiveStreamRequest"/></param>
        /// <returns>参考<see cref="ResumeLiveStreamResponse"/>实例</returns>
        public async Task<ResumeLiveStreamResponse> ResumeLiveStream(ResumeLiveStreamRequest req)
        {
             JsonResponseModel<ResumeLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置水印是否启用
        /// </summary>
        /// <param name="req">参考<see cref="SetLiveWatermarkStatusRequest"/></param>
        /// <returns>参考<see cref="SetLiveWatermarkStatusResponse"/>实例</returns>
        public async Task<SetLiveWatermarkStatusResponse> SetLiveWatermarkStatus(SetLiveWatermarkStatusRequest req)
        {
             JsonResponseModel<SetLiveWatermarkStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetLiveWatermarkStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLiveWatermarkStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 说明：录制后的文件存放于点播平台。用户如需使用录制功能，需首先自行开通点播账号并确保账号可用。录制文件存放后，相关费用（含存储以及下行播放流量）按照点播平台计费方式收取，请参考对应文档。
        /// </summary>
        /// <param name="req">参考<see cref="StopLiveRecordRequest"/></param>
        /// <returns>参考<see cref="StopLiveRecordResponse"/>实例</returns>
        public async Task<StopLiveRecordResponse> StopLiveRecord(StopLiveRecordRequest req)
        {
             JsonResponseModel<StopLiveRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopLiveRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLiveRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑域名证书
        /// </summary>
        /// <param name="req">参考<see cref="UnBindLiveDomainCertRequest"/></param>
        /// <returns>参考<see cref="UnBindLiveDomainCertResponse"/>实例</returns>
        public async Task<UnBindLiveDomainCertResponse> UnBindLiveDomainCert(UnBindLiveDomainCertRequest req)
        {
             JsonResponseModel<UnBindLiveDomainCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindLiveDomainCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindLiveDomainCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新水印
        /// </summary>
        /// <param name="req">参考<see cref="UpdateLiveWatermarkRequest"/></param>
        /// <returns>参考<see cref="UpdateLiveWatermarkResponse"/>实例</returns>
        public async Task<UpdateLiveWatermarkResponse> UpdateLiveWatermark(UpdateLiveWatermarkRequest req)
        {
             JsonResponseModel<UpdateLiveWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateLiveWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLiveWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
