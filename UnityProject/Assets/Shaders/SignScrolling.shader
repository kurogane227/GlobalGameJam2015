// Shader created with Shader Forge v1.04 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.04;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,limd:1,uamb:True,mssp:True,lmpd:False,lprd:False,rprd:False,enco:False,frtr:True,vitr:True,dbil:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:0,bsrc:0,bdst:1,culm:0,dpts:2,wrdp:True,dith:2,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.0627451,fgcg:0.1019608,fgcb:0.3058824,fgca:1,fgde:0.005,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:6699,x:32719,y:32712,varname:node_6699,prsc:2|emission-2821-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:2616,x:31690,y:32412,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_2616,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8545,x:31912,y:32464,varname:node_8545,prsc:2,ntxv:0,isnm:False|UVIN-5431-OUT,TEX-2616-TEX;n:type:ShaderForge.SFN_TexCoord,id:7922,x:31249,y:32541,varname:node_7922,prsc:2,uv:0;n:type:ShaderForge.SFN_Time,id:1392,x:31215,y:32845,varname:node_1392,prsc:2;n:type:ShaderForge.SFN_Add,id:9122,x:31572,y:32682,varname:node_9122,prsc:2|A-7922-U,B-6141-OUT;n:type:ShaderForge.SFN_Multiply,id:6141,x:31449,y:32919,varname:node_6141,prsc:2|A-1392-T,B-5776-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5776,x:31193,y:33076,ptovrint:False,ptlb:ScrollSpeed,ptin:_ScrollSpeed,varname:node_5776,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Append,id:5431,x:31731,y:32600,varname:node_5431,prsc:2|A-9122-OUT,B-7922-V;n:type:ShaderForge.SFN_Multiply,id:2821,x:32466,y:33188,varname:node_2821,prsc:2|A-6182-OUT,B-7435-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7435,x:32321,y:33376,ptovrint:False,ptlb:AmbientScale,ptin:_AmbientScale,varname:node_7435,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:8526,x:32160,y:33033,varname:node_8526,prsc:2|A-2753-OUT,B-4506-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4506,x:31980,y:33250,ptovrint:False,ptlb:LetterIntensity,ptin:_LetterIntensity,varname:node_4506,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Add,id:6182,x:32344,y:32857,varname:node_6182,prsc:2|A-8231-OUT,B-8526-OUT;n:type:ShaderForge.SFN_Subtract,id:8231,x:32089,y:32580,varname:node_8231,prsc:2|A-8545-RGB,B-8545-A;n:type:ShaderForge.SFN_Multiply,id:2753,x:31908,y:33033,varname:node_2753,prsc:2|A-8545-A,B-4118-RGB;n:type:ShaderForge.SFN_Color,id:4118,x:31732,y:33111,ptovrint:False,ptlb:LetterColor,ptin:_LetterColor,varname:node_4118,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;proporder:2616-5776-7435-4506-4118;pass:END;sub:END;*/

Shader "GGJ/SignScrolling" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _ScrollSpeed ("ScrollSpeed", Float ) = 1
        _AmbientScale ("AmbientScale", Float ) = 1
        _LetterIntensity ("LetterIntensity", Float ) = 1
        _LetterColor ("LetterColor", Color) = (0.5,0.5,0.5,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers xbox360 ps3 flash d3d11_9x 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float _ScrollSpeed;
            uniform float _AmbientScale;
            uniform float _LetterIntensity;
            uniform float4 _LetterColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
/////// Vectors:
////// Lighting:
////// Emissive:
                float4 node_1392 = _Time + _TimeEditor;
                float2 node_5431 = float2((i.uv0.r+(node_1392.g*_ScrollSpeed)),i.uv0.g);
                float4 node_8545 = tex2D(_MainTex,TRANSFORM_TEX(node_5431, _MainTex));
                float3 node_8231 = (node_8545.rgb-node_8545.a);
                float3 node_8526 = ((node_8545.a*_LetterColor.rgb)*_LetterIntensity);
                float3 emissive = ((node_8231+node_8526)*_AmbientScale);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
