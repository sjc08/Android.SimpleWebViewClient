using Android.Graphics;
using Android.Net.Http;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;

namespace Asjc.Android.SimpleWebViewClient
{
    public class SimpleWebViewClient : WebViewClient
    {
        public SimpleWebViewClient() { }

        public SimpleWebViewClient(FormResubmissionCallback? formResubmissionCallback = null,
                           LoadResourceCallback? loadResourceCallback = null,
                           PageCommitVisibleCallback? pageCommitVisibleCallback = null,
                           PageFinishedCallback? pageFinishedCallback = null,
                           PageStartedCallback? pageStartedCallback = null,
                           ReceivedClientCertRequestCallback? receivedClientCertRequestCallback = null,
                           ReceivedError1Callback? receivedError1Callback = null,
                           ReceivedError2Callback? receivedError2Callback = null,
                           ReceivedHttpAuthRequestCallback? receivedHttpAuthRequestCallback = null,
                           ReceivedHttpErrorCallback? receivedHttpErrorCallback = null,
                           ReceivedLoginRequestCallback? receivedLoginRequestCallback = null,
                           ReceivedSslErrorCallback? receivedSslErrorCallback = null,
                           RenderProcessGoneCallback? renderProcessGoneCallback = null,
                           SafeBrowsingHitCallback? safeBrowsingHitCallback = null,
                           ScaleChangedCallback? scaleChangedCallback = null,
                           TooManyRedirectsCallback? tooManyRedirectsCallback = null,
                           UnhandledInputEventCallback? unhandledInputEventCallback = null,
                           UnhandledKeyEventCallback? unhandledKeyEventCallback = null)
        {
            FormResubmission += formResubmissionCallback;
            LoadResource += loadResourceCallback;
            PageCommitVisible += pageCommitVisibleCallback;
            PageFinished += pageFinishedCallback;
            PageStarted += pageStartedCallback;
            ReceivedClientCertRequest += receivedClientCertRequestCallback;
            ReceivedError1 += receivedError1Callback;
            ReceivedError2 += receivedError2Callback;
            ReceivedHttpAuthRequest += receivedHttpAuthRequestCallback;
            ReceivedHttpError += receivedHttpErrorCallback;
            ReceivedLoginRequest += receivedLoginRequestCallback;
            ReceivedSslError += receivedSslErrorCallback;
            RenderProcessGone += renderProcessGoneCallback;
            SafeBrowsingHit += safeBrowsingHitCallback;
            ScaleChanged += scaleChangedCallback;
            TooManyRedirects += tooManyRedirectsCallback;
            UnhandledInputEvent += unhandledInputEventCallback;
            UnhandledKeyEvent += unhandledKeyEventCallback;
        }

        public delegate void FormResubmissionCallback(WebView? view, Message? dontResend, Message? resend);
        public delegate void LoadResourceCallback(WebView? view, string? url);
        public delegate void PageCommitVisibleCallback(WebView? view, string? url);
        public delegate void PageFinishedCallback(WebView? view, string? url);
        public delegate void PageStartedCallback(WebView? view, string? url, Bitmap? favicon);
        public delegate void ReceivedClientCertRequestCallback(WebView? view, ClientCertRequest? request);
        public delegate void ReceivedError1Callback(WebView? view, [GeneratedEnum] ClientError errorCode, string? description, string? failingUrl);
        public delegate void ReceivedError2Callback(WebView? view, IWebResourceRequest? request, WebResourceError? error);
        public delegate void ReceivedHttpAuthRequestCallback(WebView? view, HttpAuthHandler? handler, string? host, string? realm);
        public delegate void ReceivedHttpErrorCallback(WebView? view, IWebResourceRequest? request, WebResourceResponse? errorResponse);
        public delegate void ReceivedLoginRequestCallback(WebView? view, string? realm, string? account, string? args);
        public delegate void ReceivedSslErrorCallback(WebView? view, SslErrorHandler? handler, SslError? error);
        public delegate bool RenderProcessGoneCallback(WebView? view, RenderProcessGoneDetail? detail);
        public delegate void SafeBrowsingHitCallback(WebView? view, IWebResourceRequest? request, [GeneratedEnum] SafeBrowsingThreat threatType, SafeBrowsingResponse? callback);
        public delegate void ScaleChangedCallback(WebView? view, float oldScale, float newScale);
        public delegate void TooManyRedirectsCallback(WebView? view, Message? cancelMsg, Message? continueMsg);
        public delegate void UnhandledInputEventCallback(WebView? view, InputEvent? e);
        public delegate void UnhandledKeyEventCallback(WebView? view, KeyEvent? e);

        public event FormResubmissionCallback? FormResubmission;
        public event LoadResourceCallback? LoadResource;
        public event PageCommitVisibleCallback? PageCommitVisible;
        public event PageFinishedCallback? PageFinished;
        public event PageStartedCallback? PageStarted;
        public event ReceivedClientCertRequestCallback? ReceivedClientCertRequest;
        public event ReceivedError1Callback? ReceivedError1;
        public event ReceivedError2Callback? ReceivedError2;
        public event ReceivedHttpAuthRequestCallback? ReceivedHttpAuthRequest;
        public event ReceivedHttpErrorCallback? ReceivedHttpError;
        public event ReceivedLoginRequestCallback? ReceivedLoginRequest;
        public event ReceivedSslErrorCallback? ReceivedSslError;
        public event RenderProcessGoneCallback? RenderProcessGone;
        public event SafeBrowsingHitCallback? SafeBrowsingHit;
        public event ScaleChangedCallback? ScaleChanged;
        public event TooManyRedirectsCallback? TooManyRedirects;
        public event UnhandledInputEventCallback? UnhandledInputEvent;
        public event UnhandledKeyEventCallback? UnhandledKeyEvent;

        public override void OnFormResubmission(WebView? view, Message? dontResend, Message? resend)
        {
            base.OnFormResubmission(view, dontResend, resend);
            FormResubmission?.Invoke(view, dontResend, resend);
        }

        public override void OnLoadResource(WebView? view, string? url)
        {
            base.OnLoadResource(view, url);
            LoadResource?.Invoke(view, url);
        }

        public override void OnPageCommitVisible(WebView? view, string? url)
        {
            base.OnPageCommitVisible(view, url);
            PageCommitVisible?.Invoke(view, url);
        }

        public override void OnPageFinished(WebView? view, string? url)
        {
            base.OnPageFinished(view, url);
            PageFinished?.Invoke(view, url);
        }

        public override void OnPageStarted(WebView? view, string? url, Bitmap? favicon)
        {
            base.OnPageStarted(view, url, favicon);
            PageStarted?.Invoke(view, url, favicon);
        }

        public override void OnReceivedClientCertRequest(WebView? view, ClientCertRequest? request)
        {
            base.OnReceivedClientCertRequest(view, request);
            ReceivedClientCertRequest?.Invoke(view, request);
        }

        public override void OnReceivedError(WebView? view, [GeneratedEnum] ClientError errorCode, string? description, string? failingUrl)
        {
            base.OnReceivedError(view, errorCode, description, failingUrl);
            ReceivedError1?.Invoke(view, errorCode, description, failingUrl);
        }

        public override void OnReceivedError(WebView? view, IWebResourceRequest? request, WebResourceError? error)
        {
            base.OnReceivedError(view, request, error);
            ReceivedError2?.Invoke(view, request, error);
        }

        public override void OnReceivedHttpAuthRequest(WebView? view, HttpAuthHandler? handler, string? host, string? realm)
        {
            base.OnReceivedHttpAuthRequest(view, handler, host, realm);
            ReceivedHttpAuthRequest?.Invoke(view, handler, host, realm);
        }

        public override void OnReceivedHttpError(WebView? view, IWebResourceRequest? request, WebResourceResponse? errorResponse)
        {
            base.OnReceivedHttpError(view, request, errorResponse);
            ReceivedHttpError?.Invoke(view, request, errorResponse);
        }

        public override void OnReceivedLoginRequest(WebView? view, string? realm, string? account, string? args)
        {
            base.OnReceivedLoginRequest(view, realm, account, args);
            ReceivedLoginRequest?.Invoke(view, realm, account, args);
        }

        public override void OnReceivedSslError(WebView? view, SslErrorHandler? handler, SslError? error)
        {
            base.OnReceivedSslError(view, handler, error);
            ReceivedSslError?.Invoke(view, handler, error);
        }

        public override bool OnRenderProcessGone(WebView? view, RenderProcessGoneDetail? detail)
        {
            return RenderProcessGone?.Invoke(view, detail)
                   ?? base.OnRenderProcessGone(view, detail);
        }

        public override void OnSafeBrowsingHit(WebView? view, IWebResourceRequest? request, [GeneratedEnum] SafeBrowsingThreat threatType, SafeBrowsingResponse? callback)
        {
            base.OnSafeBrowsingHit(view, request, threatType, callback);
            SafeBrowsingHit?.Invoke(view, request, threatType, callback);
        }

        public override void OnScaleChanged(WebView? view, float oldScale, float newScale)
        {
            base.OnScaleChanged(view, oldScale, newScale);
            ScaleChanged?.Invoke(view, oldScale, newScale);
        }

        [Obsolete]
        public override void OnTooManyRedirects(WebView? view, Message? cancelMsg, Message? continueMsg)
        {
            base.OnTooManyRedirects(view, cancelMsg, continueMsg);
            TooManyRedirects?.Invoke(view, cancelMsg, continueMsg);
        }

        public override void OnUnhandledInputEvent(WebView? view, InputEvent? e)
        {
            base.OnUnhandledInputEvent(view, e);
            UnhandledInputEvent?.Invoke(view, e);
        }

        public override void OnUnhandledKeyEvent(WebView? view, KeyEvent? e)
        {
            base.OnUnhandledKeyEvent(view, e);
            UnhandledKeyEvent?.Invoke(view, e);
        }
    }
}
